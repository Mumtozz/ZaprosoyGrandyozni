

//1
//Выбрать всех студентов и их группы, отсортированных по курсам, а затем по фамилии студента:

using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using MainApp.Data;
using MainApp.Data.Entity;
using MainApp.Data.Entity.Enums;

// var res1 = (from s in DataProvider.Students
//             join sg in DataProvider.StudentGroups on s.Id equals sg.StudentId
//             join g in DataProvider.Groups on sg.GroupId equals g.Id
//             join c in DataProvider.Courses on g.CourseId equals c.Id
//             where s.Status == StudentStatus.Active && sg.StudentGroupStatus == StudentGroupStatus.Active
//             && g.GroupStatus == GroupStatus.Active
//             select new
//             {
//                 Student = s,
//                 Group = g,
//                 Course = c
//             }).OrderBy(e => e.Course.CourseName).ThenBy(e => e.Student.LastName).ToList();

// foreach (var item in res1)
// {
//     System.Console.WriteLine("--------------------------------");
//     System.Console.WriteLine($@"{item.Course.CourseName} {item.Course.CourseStatus} {item.Student.FirstName} {item.Student.Address}
//                                             {item.Group.GroupStatus} {item.Course.CreateAt}");
//     System.Console.WriteLine("---------------------------------------");
// }


//2
//Выбрать всех менторов и количество групп, которые они ведут:


// var res2 = (from mg in DataProvider.MentorGroups
//             join m in DataProvider.Mentors on mg.MentorId equals m.Id
//             join g in DataProvider.Groups on mg.GroupId equals g.Id
//             group m by m.FirstName into cls
//             select new
//             {
//                 cls.Key,
//                 Count = cls.Count()

//             });
// foreach (var item in res2)
// {
//     System.Console.WriteLine($"{item.Key} {item.Count}");
// }






//3
// //Выбрать все курсы, в которых нет групп:
// var res3 = (from c in DataProvider.Courses
//             where !DataProvider.Groups.Any(g => g.CourseId == c.Id)
//             select new{
//                     c.Id,
//                     c.CourseName
//             });
//             foreach (var item in res3)
//             {
//                 System.Console.WriteLine($"{item.CourseName} {item.Id}");
//             }









//4
//Выбрать все группы с количеством студентов и менторов в каждой группе:


var res4 = (from g in  DataProvider.Groups
            let countS= DataProvider.StudentGroups.Count(x=>x.GroupId==g.Id)
            let countM= DataProvider.MentorGroups.Count(x=>x.GroupId==g.Id)
            select new {
                Group=g.GroupName,
                CountST=countS,
                CountM=countM
                   
            }).ToList();
    foreach (var item in res4)
    {
        System.Console.WriteLine($"{item.Group} {item.CountM} {item.CountST}");
    }



//5
//Выбрать всех студентов, у которых количество групп больше среднего:


// var res5 = (from s in DataProvider.Students
//             let count = DataProvider.StudentGroups.Count(e => e.StudentId == s.Id)
//             let count2 = DataProvider.Groups.Count()
//             let avg = count * 100 / count2
//             where avg > 50
//             select new {
//                 s.LastName,
//                 s.FirstName
//             });

//             foreach (var item in res5)
//             {
//                 System.Console.WriteLine($"{item.FirstName} {item.LastName}");
//             }


//6
//Выбрать всех менторов, у которых количество студентов в группах больше определенного значения:





//7
//Выбрать все группы, в которых есть студенты обоих полов:

// var res7 = (from sg in DataProvider.StudentGroups
//             join g in DataProvider.Groups on sg.GroupId equals g.Id
//             join s in DataProvider.Students on sg.StudentId equals s.Id
//             )


// var res7 = (from g in DataProvider.Groups
//             where !DataProvider.Students.Any(e => e.Gender == Gender.Male && e.Gender == Gender.Female)
//             group g by g.GroupName into Gl
//             select new{
//                 Gl.Key
//             });
//             foreach (var item in res7)
//             {
//                 System.Console.WriteLine($"{item.Key}");
//             }

//8
//Выбрать всех студентов, которые не состоят в группе с определенным ментором:


// var res8 = (from s in DataProvider.Students
//             where !DataProvider.StudentGroups.Any(e => e.StudentId == s.Id ));





//
//9Выбрать всех менторов, которые ведут группу на курсе с наименьшим количеством студентов:



// var res9 = (from m in DataProvider.Mentors
//            )



      
//10
//Выбрать всех студентов, которые состоят в группе на курсе с наибольшим количеством менторов:


//11
//Выбрать всех студентов, принадлежащих курсу, который имеет больше всего групп:


//12
//Выбрать все группы, в которых количество студентов превышает количество менторов более чем в два раза:


//13
//Выбрать все группы, которые имеют одинаковое количество студентов и менторов:


//14
//Выбрать всех студентов, которые состоят во всех группах на всех курсах:


//15
//Выбрать все курсы, в которых количество групп превышает количество студентов:



//16
//Выбрать всех студентов, которые состоят во всех группах на курсе с наименьшим количеством менторов:


