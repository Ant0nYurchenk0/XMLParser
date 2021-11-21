using System.Collections.Generic;

namespace XMLparser
{
    internal class GlobalContext
    {
        public static string Path;
        public static List<StudentClass> Data;
        public static List<StudentClass> FilteredData;
        public static Dictionary<string, HashSet<string>> DataFilters = new Dictionary<string, HashSet<string>>();
        public static Dictionary<string, string> ActiveFilters = new Dictionary<string, string>();
        public static XMLParserStrategy Parser = new XMLParserStrategy();
        public static string[] Fields = {"Name", "School", "Department", "Year", "Address", "Date Joined"};
    }
    internal class Constant
    {
        public const string STRATEGY_ERROR = "Error: Parsing strategy not chosen";
        public const string FILE_ERROR = "Error: File not selected";
        public const int ROW_HEADER_WIDTH = 50;
        public const string HTML_BEGIN = "<!DOCTYPE HTML>\n<html>\n<style>table, th, td {border:1px solid black;}</style>\n<body>\n<table>\n";
        public const string HTML_END = "</table>\n</body>\n</html>";
        public const string ABOUT = "Done by Anton Yurchenko - Lab 2 Task 3: dorm XML file parser";
    }
}
