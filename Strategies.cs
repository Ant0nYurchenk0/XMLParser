using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;

namespace XMLparser
{
    interface Strategy
    {        
        public abstract List<StudentClass> Parse(string path);
    }

    class LINQtoXMLStrategy : Strategy
    {
        public List<StudentClass> Parse(string path)
        {
            try
            {
                XDocument file = XDocument.Load(GlobalContext.Path);
                var studentIEnum = from student in file.Descendants("student")
                                   select new StudentClass
                                   {
                                       Name = student.Element("name").Value,
                                       Department = student.Element("department").Value,
                                       School = student.Element("school").Value,
                                       Year = Convert.ToInt32(student.Element("year").Value),
                                       Address = student.Element("address").Value,
                                       DateJoined = Convert.ToDateTime(student.Element("dateJoined").Value).Date};
                return studentIEnum.ToList();
            }
            catch
            {
                MessageBox.Show(Constant.FILE_ERROR);
                return null;
            }
        }
    }
    class SAXAPIstrategy : Strategy
    {
        public List<StudentClass> Parse(string path)
        {
            try
            {
                List<StudentClass> studentList = new List<StudentClass>();
                string name = string.Empty;
                int year = 0;
                string school = string.Empty;
                string department = string.Empty;
                string element = string.Empty;
                string address = string.Empty;
                DateTime dateJoined = DateTime.Now;
                XmlReader file = XmlReader.Create(path);
                while (file.Read())
                {
                    if (file.NodeType == XmlNodeType.Element)
                    {
                        element = file.Name; 
                    }
                    else if (file.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "year":
                                year = Convert.ToInt32(file.Value);
                                break;
                            case "name":
                                name = file.Value;
                                break;
                            case "school":
                                school = file.Value;
                                break;
                            case "department":
                                department = file.Value;
                                break;
                            case "address":
                                address = file.Value;
                                break;
                            case "dateJoined":
                                dateJoined = Convert.ToDateTime(file.Value).Date;
                                break;
                        }
                    }
                    else if ((file.NodeType == XmlNodeType.EndElement) 
                            && (file.Name == "student"))
                    {
                        studentList.Add(new StudentClass(name, year, school, department, address, dateJoined));
                    }
                }
                return studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString());
                return null;
            }
        }
    }
    class DOMAPIstrategy : Strategy
    {
        public List<StudentClass> Parse(string path)
        {
            try
            {
                List<StudentClass> studentList = new List<StudentClass>();
                XmlDocument file = new XmlDocument();
                file.Load(path);
                foreach (XmlNode studentNode in file.GetElementsByTagName("student"))
                {
                    studentList.Add(new StudentClass
                    {
                        Name = studentNode["name"].ChildNodes[0].Value,
                        Year = Convert.ToInt32(studentNode["year"].ChildNodes[0].Value),
                        Department = studentNode["department"].ChildNodes[0].Value,
                        School = studentNode["school"].ChildNodes[0].Value,
                        Address = studentNode["address"].ChildNodes[0].Value,
                        DateJoined = Convert.ToDateTime(studentNode["dateJoined"].ChildNodes[0].Value).Date});
                }
                return studentList;
            }
            catch
            {
                MessageBox.Show(Constant.FILE_ERROR);
                return null;
            }
        }
    }
}
//string name = string.Empty;
//int year = 0;
//string school = string.Empty;
//string department = string.Empty;
//string element = string.Empty;
//XmlReader file = XmlReader.Create(path);
//while (file.Read())
//{
//    // reads the element
//    if (file.NodeType == XmlNodeType.Element)
//    {
//        element = file.Name; // the name of the current element
//        if (element == "user")
//        {
//            year = int.Parse(file.GetAttribute("year"));
//        }
//    }
//    // reads the element value
//    else if (file.NodeType == XmlNodeType.Text)
//    {
//        switch (element)
//        {
//            case "name":
//                name = file.Value;
//                break;
//            case "school":
//                school = file.Value;
//                break;
//            case "department":
//                department = file.Value;
//                break;
//        }
//    }
//    // reads the closing element
//    else if ((file.NodeType == XmlNodeType.EndElement) && (file.Name == "user"))
//        studentList.Add(new StudentClass
//        {
//            Name = name,
//            School = school,
//            Year = year,
//            Department = department
//        });
//}