using AppointRecognition.Domain;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppointRecognition
{
    class Program
    {
        #region -- Configuration --
        public class Configuration
        {
            public class Category
            {
                public string Name { get; set; }
                public string[] Values { get; set; }
            }

            public string[] Services { get; set; }
            public string[] Garbage { get; set; }
            public Category[] Genders { get; set; }
            public Category[] Ages { get; set; }
            public string[] Cities { get; set; }
        }

        public class Service
        {
            public string Title { get; set; }
            public string Gender { get; set; }
            public string Age { get; set; }
            public List<string[]> IndexKey { get; set; }
        }

        static Configuration _config;
        static Hashtable _genderMapping = new Hashtable();
        static Hashtable _ageMapping = new Hashtable();
        static Hashtable _indexByGender = new Hashtable();
        static Hashtable _indexByAge = new Hashtable();
        static Hashtable _indexByKeyword = new Hashtable();

        static void Initialize()
        {
            using (var file = new StreamReader("config.json"))
            {
                _config = JsonConvert.DeserializeObject<Configuration>(file.ReadToEnd());
            }

            _config.Garbage = _config.Garbage.OrderBy(G => G).ToArray();
            _config.Cities = _config.Cities.OrderBy(C => C).ToArray();

            // Populate _genderMapping.
            for (int i = _config.Genders.Length - 1; i >= 0; --i)
            {
                for (int j = _config.Genders[i].Values.Length - 1; j >= 0; --j)
                {
                    _genderMapping[_config.Genders[i].Values[j]] = _config.Genders[i].Name;
                }
            }

            // Populate _ageMapping.
            for (int i = _config.Ages.Length - 1; i >= 0; --i)
            {
                for (int j = _config.Ages[i].Values.Length - 1; j >= 0; --j)
                {
                    _ageMapping[_config.Ages[i].Values[j]] = _config.Ages[i].Name;
                }
            }

            for (int i = 0; i < _config.Genders.Length; ++i)
                _indexByGender.Add(_config.Genders[i].Name, new List<Service>());

            for (int i = 0; i < _config.Ages.Length; ++i)
                _indexByAge.Add(_config.Ages[i].Name, new List<Service>());

            // Convert service string to service object.
            // Populate _indexbyGender, _indexByAge and _indexByKeyword.
            for (int i = _config.Services.Length - 1; i >= 0; --i)
            {
                var service = _config.Services[i];
                var serviceObj = new Service();

                serviceObj.Title = service;
                service = service.ToLower();

                string gender = null;
                string age = null;
                service = GenderAgeFilter(service, ref gender, ref age);
                serviceObj.Gender = string.IsNullOrWhiteSpace(gender) ? "default" : gender;
                serviceObj.Age = string.IsNullOrWhiteSpace(age) ? "default" : age;

                service = GarbageFilter(service);

                serviceObj.IndexKey = KeywordsFilter(service);

                // Add the service object to _indexByGender.
                if (serviceObj.Gender.Equals("default") == false)
                    ((List<Service>)_indexByGender[serviceObj.Gender]).Add(serviceObj);

                // Add the service object to _indexByAge.
                if (serviceObj.Age.Equals("default") == false)
                    ((List<Service>)_indexByAge[serviceObj.Age]).Add(serviceObj);

                // Add the service object to _indexByKeyword.
                // serviceObj.IndexKey = 
                //    [0] = ["111", "222, "333"]
                //    [1] = ["111;222", "111;333", "222;333"]
                //    [2] = ["111;222;333"]
                for (int j = 0; j < serviceObj.IndexKey.Count; ++j)
                {
                    for (int k = 0; k < serviceObj.IndexKey[j].Length; ++k)
                    {
                        var key = serviceObj.IndexKey[j][k]; // "111", "222", "333", "111;222", "111;333", "222;333", "111;222;333"

                        if (_indexByKeyword.ContainsKey(key) == false)
                            _indexByKeyword.Add(key, new List<Service>());

                        ((List<Service>)_indexByKeyword[key]).Add(serviceObj);
                    }
                }
                // serviceHash = 
                //  "111" -> serviceObj1, serviceObj2, serviceObj3
                //  "222" -> serviceObj1
                //  "333" -> serviceObj1, serviceObj3
                //  ...
                //  "111;222;333" -> serviceObj1
            }
        }
        #endregion

        #region -- Filters --
        static bool RemoveFilter(string input, string pattern, ref string removed, ref string remainder)
        {
            // input = "Lisa's women haircut"
            // pattern = "women"
            // remainder = "Lisa's  haircut"

            var regex = new Regex(pattern);
            var match = regex.Match(input);
            if (match.Success)
            {
                removed = match.Value;
                remainder = regex.Replace(input, "");
                return true;
            }

            return false;
        }

        static string GenderAgeFilter(string input, ref string gender, ref string age)
        {
            age = "default";
            gender = "default";
            string remainder = null;
            string removed = null;

            foreach (string genderKey in _genderMapping.Keys)
            {
                if (RemoveFilter(input, genderKey, ref removed, ref remainder))
                {
                    gender = _genderMapping[genderKey] as string;

                    foreach (string ageKey in _ageMapping.Keys)
                    {
                        var regex = new Regex(ageKey);
                        if (regex.IsMatch(removed))
                        {
                            age = _ageMapping[ageKey] as string;
                            return remainder;
                        }
                    }

                    input = remainder;
                    break;
                }
            }

            foreach (string ageKey in _ageMapping.Keys)
            {
                removed = remainder = null;
                if (RemoveFilter(input, ageKey, ref removed, ref remainder))
                {
                    age = _ageMapping[ageKey] as string;
                    return remainder;
                }
            }

            return input;
        }

        static string LocationFilter(string input, ref string result)
        {
            for (int i = _config.Cities.Length - 1; i >= 0; --i)
            {
                string removed = null;
                string remainder = null;
                if (RemoveFilter(input, _config.Cities[i], ref removed, ref remainder))
                {
                    result = _config.Cities[i];
                    return remainder;
                }
            }

            result = null;
            return input;
        }

        #region -- TimeFilter Regex --
        static Regex _TimeRegex = new Regex(@"((0[\d]|1[\d]|2[0-3]|[0\d]):([1-5][\d]|0[\d]|[\d]):([1-5][\d]|0[\d][\d])|(0[\d]|1[\d]|2[0-3]|[\d]):([1-5][\d]|0[\d]|[\d]))\s*(am|pm)*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _HourRegex = new Regex(@"([^\d]|^)(1[0-2]|0[1-9]|[1-9])\s*(am|pm)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _HourHintRegex = new Regex(@"at (1[0-2]|0[1-9]|[1-9])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _MorningRegex = new Regex("morning", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _AfternoonRegex = new Regex("afternoon", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _EveningRegex = new Regex("evening", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        #endregion

        static string TimeFilter(string input, ref TimeSpan? from, ref TimeSpan? to)
        {
            from = to = null;
            int maxHour;
            int hourOffset;
            int hour;

            var match = _TimeRegex.Match(input);
            if (match.Success)
            {
                TimeSpan time;
                if (match.Groups[7].Length > 0)
                {
                    maxHour = 12;
                    hourOffset = match.Groups[7].Value.Equals("pm") ? 12 : 0;
                }
                else
                {
                    maxHour = 24;
                    hourOffset = 0;
                }

                if (TimeSpan.TryParse(match.Groups[1].Value, out time))
                    if (time.Hours < maxHour)
                        from = to = new TimeSpan(time.Hours + hourOffset, time.Minutes, time.Seconds);

                if (from.HasValue)
                    return _TimeRegex.Replace(input, "");
            }

            match = _HourRegex.Match(input);
            if (match.Success)
            {
                hourOffset = match.Groups[3].Value.Equals("pm") ? 12 : 0;

                if (int.TryParse(match.Groups[2].Value, out hour))
                    from = to = new TimeSpan(hour + hourOffset, 0, 0);

                if (from.HasValue)
                    return _HourRegex.Replace(input, "");
            }

            match = _HourHintRegex.Match(input);
            if (match.Success)
            {
                if (int.TryParse(match.Groups[1].Value, out hour))
                {
                    if (hour >= 1 && hour <= 6)
                        from = to = new TimeSpan(hour + 12, 0, 0);
                    else if (hour >= 7 && hour <= 12)
                        from = to = new TimeSpan(hour, 0, 0);
                }

                if (from.HasValue)
                    return _HourHintRegex.Replace(input, "");
            }

            if (_MorningRegex.IsMatch(input))
            {
                from = new TimeSpan(9, 0, 0);
                to = new TimeSpan(12, 0, 0);
                return _MorningRegex.Replace(input, "");
            }

            if (_AfternoonRegex.IsMatch(input))
            {
                from = new TimeSpan(14, 0, 0);
                to = new TimeSpan(18, 0, 0);
                return _AfternoonRegex.Replace(input, "");
            }

            if (_EveningRegex.IsMatch(input))
            {
                from = new TimeSpan(18, 0, 0);
                to = new TimeSpan(22, 0, 0);
                return _EveningRegex.Replace(input, "");
            }

            return input;
        }

        #region -- DateFilter Regex --
        static Regex _TodayRegex = new Regex("today", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _TomorrowRegex = new Regex("tomorrow|tommorow|tomorow|tommorrow", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _RelativeDayRegex = new Regex(@"(next)*\s*(sunday|monday|tuesday|wednesday|thursday|friday|saturday|sun|mon|tue|wed|thu|fri|sat)+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Dictionary<string, DayOfWeek> _DayOfWeekDict = new Dictionary<string, DayOfWeek>()
        {
            { "sunday", DayOfWeek.Sunday }, { "sun", DayOfWeek.Sunday },
            { "monday", DayOfWeek.Monday }, { "mon", DayOfWeek.Monday },
            { "tuesday", DayOfWeek.Tuesday }, { "tue", DayOfWeek.Tuesday },
            { "wednesday", DayOfWeek.Wednesday }, { "wed", DayOfWeek.Wednesday },
            { "thursday", DayOfWeek.Thursday }, { "thu", DayOfWeek.Thursday },
            { "friday", DayOfWeek.Friday }, { "fri", DayOfWeek.Friday },
            { "saturday", DayOfWeek.Saturday }, { "sat", DayOfWeek.Saturday }
        };

        static Regex _NextWeekRegex = new Regex(@"next\s*week", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _ThisWeekendRegex = new Regex(@"this\s*week\s*end", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _NextWeekendRegex = new Regex(@"next\s*week\s*end", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex _NextMonthRegex = new Regex(@"next\s*month", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        static Regex _InMonthRegex = new Regex("(january|february|march|april|may|june|july|august|september|october|november|december|jan|feb|mar|apr|jun|jul|aug|sep|oct|nov|dec)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Dictionary<string, int> _MonthDict = new Dictionary<string, int>()
        {
            { "january", 1 }, { "jan", 1 },
            { "february", 2 }, { "feb", 2 },
            { "march", 3 }, { "mar", 3 },
            { "april", 4 }, { "apr", 4 },
            { "may", 5 }, 
            { "june", 6 }, { "jun", 6 },
            { "july", 7 }, { "jul", 7 },
            { "august", 8 }, { "aug", 8 },
            { "september", 9 }, { "sep", 9 },
            { "october", 10 }, { "oct", 10 },
            { "november", 11 }, { "nov", 11 },
            { "december", 12 }, { "dec", 12 }
        };
        #endregion

        static string DateFilter(string input, ref DateTime? from, ref DateTime? to)
        {
            DateTime today = DateTime.Today;
            from = to = null;
            DateTime olddate;

            var match = _InMonthRegex.Match(input);
            if (match.Success)
            {
                if (today.Month <= _MonthDict[match.Groups[1].Value])
                    olddate = today.AddMonths(_MonthDict[match.Groups[1].Value] - today.Month);
                else
                    olddate = today.AddMonths(12 - today.Month + _MonthDict[match.Groups[1].Value]);
                from = new DateTime(olddate.Year, olddate.Month, 1, 0, 0, 0, olddate.Kind);
                olddate = olddate.AddMonths(1);
                to = new DateTime(olddate.Year, olddate.Month, 1, 0, 0, 0, olddate.Kind).AddDays(-1);
                return _InMonthRegex.Replace(input, "");
            }

            if (_ThisWeekendRegex.IsMatch(input))
            {
                if ((int)today.DayOfWeek <= (int)DayOfWeek.Saturday)
                {
                    from = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek);
                    to = from.Value.AddDays(1);
                }
                else if ((int)today.DayOfWeek == (int)DayOfWeek.Sunday)
                {
                    from = to = today;
                }
                return _ThisWeekendRegex.Replace(input, "");
            }

            if (_NextWeekendRegex.IsMatch(input))
            {
                from = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek + (int)DayOfWeek.Saturday + 1);
                to = from.Value.AddDays(1);
                return _NextWeekendRegex.Replace(input, "");
            }

            if (_NextWeekRegex.IsMatch(input))
            {
                from = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek + (int)DayOfWeek.Monday + 1);
                to = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek + (int)DayOfWeek.Saturday + 2);
                return _NextWeekRegex.Replace(input, "");
            }

            if (_NextMonthRegex.IsMatch(input))
            {
                olddate = today.AddMonths(1);
                from = new DateTime(olddate.Year, olddate.Month, 1, 0, 0, 0, olddate.Kind);
                olddate = olddate.AddMonths(1);
                to = new DateTime(olddate.Year, olddate.Month, 1, 0, 0, 0, olddate.Kind).AddDays(-1);
                return _NextMonthRegex.Replace(input, "");
            }

            if (_TodayRegex.IsMatch(input))
            {
                from = to = today.AddDays(0);
                return _TodayRegex.Replace(input, "");
            }
            
            if (_TomorrowRegex.IsMatch(input))
            {
                from = to = today.AddDays(1);
                return _TomorrowRegex.Replace(input, "");
            }

            match = _RelativeDayRegex.Match(input);
            if (match.Success)
            {
                if (match.Groups[1].Length == 0 && (int)today.DayOfWeek <= (int)_DayOfWeekDict[match.Groups[2].Value])
                    from = to = today.AddDays((int)_DayOfWeekDict[match.Groups[2].Value] - (int)today.DayOfWeek);
                else
                    from = to = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek + (int)_DayOfWeekDict[match.Groups[2].Value] + 1);
                return _RelativeDayRegex.Replace(input, "");
            }

            return input;
        }

        static string GarbageFilter(string input)
        {
            foreach (string garbage in _config.Garbage.Reverse())
            {
                string removed = null;
                string remainder = null;
                if (RemoveFilter(input, garbage, ref removed, ref remainder))
                    input = remainder;
            }

            return input;
        }

        static List<string[]> KeywordsFilter(string input)
        {
            var result = new List<string[]>();

            //input = "222 111-333";

            var words = input.Split(" ,;\b".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).OrderBy(K => K).ToList();
            // words = ["111-333", "222"]

            for (int i = words.Count - 1; i >= 0; --i)
            {
                var splits = words[i].Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (splits.Length > 1)
                    words.AddRange(splits);
            }
            // words = ["111-333", "222", "111", "333"]

            for (int i = 1; i <= words.Count; ++i)
            {
                var comboList = generateKeywordCombo(words.ToArray(), i);
                result.Add(
                    (from C in comboList
                     let R = transformKeywordCombo(C)
                     where R != null
                     orderby R
                     select R).ToArray());
            }
            // result =
            //    [0] = ["111", "111-333", "222, "333"]
            //    [1] = ["111;222", "111;333", "111-333;222", "222;333",]
            //    [2] = ["111;222;333"]
            //    [3] = []

            return result;
        }

        static List<string[]> generateKeywordCombo(string[] keywords, int comboLen)
        {
            List<string[]> resultList = new List<string[]>();

            if (comboLen > keywords.Length)
                return resultList;

            int[] index = new int[comboLen];

            // Initial index
            // If comboLen=3, then index[] = 0 1 2
            for (int i = 0; i < comboLen; ++i)
                index[i] = i;

            resultList.Add(index.Select(I => keywords[I]).ToArray());

            while (true)
            {
                int i;

                // Find the rightmost index element who has not reached the max possible index value.
                // If index[] = 0 1 2, then index[] = 0 1 3
                // If index[] = 0 1 4, then index[] = 0 2 ?
                for (i = comboLen - 1; i >= 0 && index[i] == keywords.Length - comboLen + i; --i) ;
                if (i < 0)
                    break;
                index[i]++;

                // Initialize index[] = 0 2 ? to index[] = 0 2 3
                for (++i; i < comboLen; ++i)
                    index[i] = index[i - 1] + 1;

                resultList.Add(index.Select(I => keywords[I]).ToArray());
            }

            return resultList;

            // index[] history
            //  0 1 2
            //  0 1 3
            //  0 1 4
            //  0 2 ?
            //  0 2 3
            //  0 2 4
            //  0 3 ?
            //  0 3 4
            //  1 ? ?
            //  1 2 3
            //  1 2 4
            //  1 3 ?
            //  1 3 4
            //  2 ? ?
            //  2 3 4
        }

        static string transformKeywordCombo(string[] keywordCombo)
        {
            int i = 0, j = 0;
            for (i = keywordCombo.Length - 1; i >= 0; --i)
            {
                for (j = keywordCombo.Length - 1; j >= 0; --j)
                {
                    if (i == j)
                        continue;
                    if (keywordCombo[i].Contains(keywordCombo[j]) || keywordCombo[j].Contains(keywordCombo[i]))
                        break;
                }

                if (j >= 0)
                    break;

                if (i == 0)
                    return string.Join(";", keywordCombo.OrderBy(K => K));
            }

            return null;
        }

        static Regex _ExitRegex = new Regex("^\\s*(exit|(good)*\\s*bye|see you\\s*$|done\\s*$|leave\\s*$|nothing\\s*$|that's\\s*all\\s*$)\\s*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static bool ExitFilter(string input)
        {
            return _ExitRegex.IsMatch(input);
        }
        #endregion

        #region -- Request --
        public class Request
        {
            public class When
            {
                public TimeSpan? BeginTime { get; set; }
                public TimeSpan? EndTime { get; set; }
                public DateTime? BeginDate { get; set; }
                public DateTime? EndDate { get; set; }
            }

            public class Where
            {
                public string City { get; set; }
            }

            public class Who
            {
                public string Gender { get; set; }
                public string Age { get; set; }
            }

            public class What
            {
                public string Action { get; set; }
                public List<string[]> IndexKeys { get; set; }
            }

            public Who People { get; set; }
            public What Subject { get; set; }
            public Where Location { get; set; }
            public When DateTime { get; set; }
        }

        static Request ParseRequest(string requestStr)
        {
            var request = new Request();
            requestStr = requestStr.Trim().ToLower();

            string gender = null;
            string age = null;
            requestStr = GenderAgeFilter(requestStr, ref gender, ref age);
            request.People = new Request.Who() { Gender = gender, Age = age };

            string city = null;
            requestStr = LocationFilter(requestStr, ref city);
            request.Location = new Request.Where() { City = city };

            DateTime? fromDate = null;
            DateTime? toDate = null;
            requestStr = DateFilter(requestStr, ref fromDate, ref toDate);
            request.DateTime = new Request.When() { BeginDate = fromDate, EndDate = toDate };

            TimeSpan? fromTime = null;
            TimeSpan? toTime = null;
            requestStr = TimeFilter(requestStr, ref fromTime, ref toTime);
            request.DateTime.BeginTime = fromTime;
            request.DateTime.EndTime = toTime;

            requestStr = GarbageFilter(requestStr);

            request.Subject = new Request.What() { IndexKeys = KeywordsFilter(requestStr) };

            return request;
        }
        #endregion

        #region -- Processing --
        static List<Service> FindServices(Request request)
        {
            // Returns special age group if found.
            if (request.People.Age.Equals("default") == false)
            {
                var servicesByAge = (List<Service>)_indexByAge[request.People.Age];
                if (servicesByAge.Count > 0)
                    return servicesByAge;
            }


            // Finds the special gender group.
            List<Service> servicesByGender = null;
            if (request.People.Gender.Equals("default") == false)
            {
                servicesByGender = (List<Service>)_indexByGender[request.People.Gender];
                if (servicesByGender.Count == 0)
                    servicesByGender = null;
            }

            var servicesFound = new List<Service>();
            for (int i = request.Subject.IndexKeys.Count - 1; i >= 0; --i)
            {
                for (int j = 0; j < request.Subject.IndexKeys[i].Length; ++j)
                {
                    // [i] = [...j.....]
                    // [2] = ["111;222;333"]
                    // [1] = ["111;222", "111;333", "222;333"]
                    // [0] = ["111", "222, "333"]

                    var key = request.Subject.IndexKeys[i][j];
                    if (_indexByKeyword.ContainsKey(key))
                        servicesFound.AddRange(((List<Service>)_indexByKeyword[key]).Where(S => servicesByGender == null || servicesByGender.Contains(S)));
                }

                if (servicesFound.Count > 0)
                    return servicesFound.Distinct().ToList();
            }

            return servicesFound;
        }

        static bool CheckMissingInformation(Request request)
        {
            string requestStr;

            if (request.Location.City == null)
            {
                string city = null;
                requestStr = GetAnswerToQuestion("", "In which city do you want to find the service?", ">> ");
                requestStr = requestStr.Trim().ToLower();
                requestStr = LocationFilter(requestStr, ref city);
                if (string.IsNullOrWhiteSpace(city))
                    return false;
                request.Location.City = city;
            }

            if (request.DateTime.BeginDate == null)
            {
                DateTime? fromDate = null;
                DateTime? toDate = null;
                if (request.DateTime.BeginTime == null)
                {
                    requestStr = GetAnswerToQuestion("", "What day and time would you like to receive the service?", ">> ");
                    requestStr = requestStr.Trim().ToLower();
                    requestStr = DateFilter(requestStr, ref fromDate, ref toDate);
                    request.DateTime.BeginDate = fromDate.HasValue ? fromDate.Value : DateTime.Today.AddDays(1);
                    request.DateTime.EndDate = toDate.HasValue ? toDate.Value : request.DateTime.BeginDate;
                    TimeSpan? fromTime = null;
                    TimeSpan? toTime = null;
                    requestStr = TimeFilter(requestStr, ref fromTime, ref toTime);
                    request.DateTime.BeginTime = fromTime.HasValue ? fromTime.Value : new TimeSpan(14, 0, 0);
                    request.DateTime.EndTime = toTime.HasValue ? toTime.Value : new TimeSpan(22, 0, 0);
                }
                else
                {
                    requestStr = GetAnswerToQuestion("", "What day would you like to receive the service?", ">> ");
                    requestStr = requestStr.Trim().ToLower();
                    requestStr = DateFilter(requestStr, ref fromDate, ref toDate);
                    request.DateTime.BeginDate = fromDate.HasValue ? fromDate.Value : DateTime.Today.AddDays(1);
                    request.DateTime.EndDate = toDate.HasValue ? toDate.Value : request.DateTime.BeginDate;
                }
            }
            else if (request.DateTime.BeginTime == null)
            {
                requestStr = GetAnswerToQuestion("", "What time would you like to receive the service?", ">> ");
                requestStr = requestStr.Trim().ToLower();
                TimeSpan? fromTime = null;
                TimeSpan? toTime = null;
                requestStr = TimeFilter(requestStr, ref fromTime, ref toTime);
                request.DateTime.BeginTime = fromTime;
                request.DateTime.EndTime = toTime;
            }

            return true;
        }

        static void ProcessRequest(Request request)
        {
            if (CheckMissingInformation(request) == false)
            {
                ShowMessages("", "No service was found. Please request another one.");
                return;
            }

            var servicesFound = FindServices(request);
            if (servicesFound.Count == 0)
            {
                ShowMessages("", "No service was found. Please request another one.");
            }
            else
            {
                string requestStr;

                Service serviceSelected = null;
                if (servicesFound.Count > 1)
                {
                    var messages = new List<string>();
                    int item = 1;
                    foreach (string service in servicesFound.Select(S => S.Title))
                        messages.Add(string.Format("  {0}) {1}", item++, service));

                    ShowMessages("", "Please select the number corresponding to the service:");
                    for (int i = 0; i < 3; ++i)
                    {
                        ShowMessages(messages.ToArray());
                        requestStr = GetAnswerToQuestion(">> ");
                        if (int.TryParse(requestStr, out item))
                        {
                            if (item > 0 && item <= servicesFound.Count)
                            {
                                serviceSelected = servicesFound[item - 1];
                                break;
                            }
                        }

                        ShowMessages("", "Sorry, I did not get that. Please select a number shown below: ");
                    }

                    if (serviceSelected == null)
                        ShowMessages("", "Hmm... I cannot understand your choice.");
                }
                else
                    serviceSelected = servicesFound[0];

                var results = new List<string>() { "", "Thank you! The following service is booked:", string.Format("  Service: {0}", serviceSelected.Title) };

                if (request.DateTime.BeginDate != null || request.DateTime.BeginTime != null)
                {
                    var sb = new StringBuilder();

                    if (request.DateTime.BeginTime != null)
                        sb.Append(new DateTime(2000, 1, 1, request.DateTime.BeginTime.Value.Hours, request.DateTime.BeginTime.Value.Minutes, request.DateTime.BeginTime.Value.Seconds).ToLongTimeString());

                    if (request.DateTime.BeginDate != null)
                    {
                        if (sb.Length > 0)
                            sb.Append(" on ");
                        sb.Append(request.DateTime.BeginDate.Value.ToLongDateString());
                    }

                    sb.Insert(0, "  Time: ");
                    results.Add(sb.ToString());
                }

                results.Add(string.Format("  Location: {0}", request.Location.City ?? "N/A"));
                ShowMessages(results.ToArray());
            }
        }

        static string GetAnswerToQuestion(params string[] messages)
        {
            for (int i = 0; i < messages.Length - 1; ++i)
                Console.WriteLine(messages[i]);
            Console.Write(messages.Last());
            return Console.ReadLine();
        }

        static void Exit(int exitCode = 0, params string[] messages)
        {
            ShowMessages(messages);
            Console.WriteLine();
            System.Environment.Exit(exitCode);
        }

        static void ShowMessages(params string[] messages)
        {
            if (messages != null && messages.Length > 0)
                foreach (string message in messages)
                    Console.WriteLine(message);
        }
        #endregion
        
        static void Main(string[] args)
        {
            Initialize();

            while (true)
            {
                var requestStr = GetAnswerToQuestion("", "What can I do for you?", ">> ");
                if (ExitFilter(requestStr))
                    Exit(0, "Goodbye ...");

                ProcessRequest(ParseRequest(requestStr));
            }
        }
    }
}