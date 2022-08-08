

var students = new List<Student> {
new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Aishwarya",LastName="Verma",Age=19, Gender="F", TeamName="A" },

new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
};

// 1.get all the students count for each team
Console.WriteLine("......................Count of all Students...............");

var StudentsCount = students.GroupBy(x => x.TeamName);
foreach(var student in StudentsCount)
{
    Console.WriteLine(student.Key +": "+ student.Count());   
}
Console.WriteLine();Console.WriteLine();

//2. get all the male students list
Console.WriteLine(".....................Male Students List.........................");

var MaleStudent=students.Where(s => s.Gender.ToUpper() == "M");
foreach(var student in MaleStudent)
{
   // Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age + " " + student.Gender + " " + student.TeamName);
    Console.WriteLine(student.ToString());
}
Console.WriteLine(); Console.WriteLine();


//3. get all the female students list
Console.WriteLine("...................Female student List............................");

var FemaleStudent = students.Where(s => s.Gender.ToUpper() == "F");
foreach (var student in FemaleStudent)
{
    Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age + " "+student.Gender+" " + student.TeamName);
}
Console.WriteLine(); Console.WriteLine();

//4. get all the male students with age 20
Console.WriteLine(".......................Male Students whose age is 20..............................");
var StudentmaleWith21=students.Where(s => s.Gender == "M" && s.Age==20);
foreach (var student in StudentmaleWith21) {
    Console.WriteLine(student.ToString());
}
Console.WriteLine(); Console.WriteLine();


//5. get all the female students with age 19
Console.WriteLine("....................Female Students whose age is 19.........................");

var StudentFemaleWith19 = students.Where(s => s.Gender == "F" && s.Age == 19);
foreach (var student in StudentFemaleWith19)
{
    Console.WriteLine(student.ToString());
}
Console.WriteLine(); Console.WriteLine();


//6. get all the students starts with FirstName as "A or a"
Console.WriteLine("All students Firstname starts from A or a...........................");
var StudentsFirstNameStartsWithA=students.Where(s => (s.FirstName.StartsWith('A') || s.FirstName.StartsWith('a')));
foreach(var student in StudentsFirstNameStartsWithA)
{
    Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age + " " + student.TeamName);
   
}
Console.WriteLine(); Console.WriteLine("Using Different Method");

var StudentsFirstNameStartsWithA2 = students.Where(s => (s.FirstName[0] == 'A' || s.FirstName[0]=='a'));
foreach(var student in StudentsFirstNameStartsWithA2)
{
    Console.WriteLine(student.ToString());
}
Console.WriteLine(); Console.WriteLine();


//7. get all the students whose lastname is ""(empty)
Console.WriteLine("Students Whose last Name is Empty............................");

var lastnameEmpty=students.Where(s => s.LastName=="");
foreach(var student in lastnameEmpty)
{
    Console.WriteLine(student.FirstName+" "+student.LastName +" "+student.Age+" "+student.Gender+" "+student.TeamName);
}
Console.WriteLine(); Console.WriteLine();


//8.get top 2 students in each team(for example Amara and Muskan are top 2 students in A team)
Console.WriteLine("Top 2 Students in each team............................");
var Top2Students=students.GroupBy(s => s.TeamName);
    foreach (var student in Top2Students)
    {
        Console.WriteLine("Team "+student.Key);
   var st= student.Take(2);
    foreach(var s in st)
    {
        Console.WriteLine(s.ToString());
    }
    }
Console.WriteLine(); Console.WriteLine();


//9.get the students from 8th position to 17th position
Console.WriteLine("Students From 8th to 17th position................................");
var StudentsOnPosition=students.Select(s => new { s.FirstName, s.LastName,s.Age,s.Gender,s.TeamName }).Take(new Range(7,17));
foreach(var student in StudentsOnPosition)
{
    Console.WriteLine(student.ToString());
}
Console.WriteLine(); Console.WriteLine();


//10. get all the students FirstName with Age 
Console.WriteLine("All student name and age...................................");
var FirstNameAndAge=students.Select(s => new {s.FirstName ,s.Age});
foreach(var student in FirstNameAndAge) {
    Console.WriteLine(student.FirstName+" "+ student.Age);
}
Console.WriteLine(); Console.WriteLine();


var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8 ,9};

//1.find the unique element in this list
Console.WriteLine("Unique Element in list..../////////////////////////////////");
var UniqueElements=numbers.GroupBy(x => x).Where(x=>x.Count()==1);
foreach(var student in UniqueElements)
{
    Console.WriteLine(student.Key);
}
Console.WriteLine("different way.....");
var UniqueElements2 = numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x=>x.Key);
foreach (var student in UniqueElements2)
{
    Console.WriteLine(student);
}

Console.WriteLine(); Console.WriteLine();

//2. find the distinct elements
Console.WriteLine("Distinct Elements in List........//////////////////////");
var DistinctElement = numbers.Distinct();
foreach (var s in DistinctElement)
{
    Console.WriteLine(s);
}
Console.WriteLine(); Console.WriteLine();


//3. find the maximum occurred element
Console.WriteLine("Maximum Occured Element.............///////////////////");
var Maximum=numbers.GroupBy(x=> x).MaxBy(x=> x.Count()).First();
Console.WriteLine(Maximum);
Console.WriteLine(); Console.WriteLine();


//4. find the minimum occurred element
Console.WriteLine("minimum occured element........///////////////");
var Minimum = numbers.GroupBy(x => x).MinBy(x => x.Count()).First();
Console.WriteLine(Minimum);
Console.WriteLine(); Console.WriteLine();


//5. find the even and odd numbers
Console.WriteLine("even numbers........../////////////////");
var EvenNumbers=numbers.Where(x => x % 2 == 0).Distinct();
foreach(var s in EvenNumbers)
{
    Console.WriteLine(s);
}
Console.WriteLine(); Console.WriteLine();

Console.WriteLine("odd numbers........../////////////////");
var OddNumbers = numbers.Where(x => x % 2 !=0).Distinct();
foreach (var s in OddNumbers)
{
    Console.WriteLine(s);
}
Console.WriteLine(); Console.WriteLine();

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string TeamName { get; set; }

    public override string ToString()
    {
        return (this.FirstName + " " + this.LastName + " " + this.Age + " "+ this.Gender+" " + this.TeamName);
    }

}



