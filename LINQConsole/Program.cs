﻿using System.Diagnostics.CodeAnalysis;



/*Student myStudent = new Student();
myStudent.FirstName = "A";
myStudent.LastName = "B";

List<Student> myStudentList = new List<Student>();
myStudentList.Add(myStudent);*/


//object initializer
var myStudent1 = new Student { FirstName = "AA", LastName = "BB", Age = 10 };

//anonymous object and initializer
var anonymousStudent = new { FirstName = "AA", LastName = "BB", Age = 10 };



//anonymous student Array
var students11 = new[] {
new {FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
new {FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
new {FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
new {FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
new {FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

new {FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
new {FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
new {FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
new {FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
new {FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

new {FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
new {FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
new {FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
new {FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
new {FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

new {FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
new {FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
new {FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
new {FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
new {FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
new {FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
};

//object and collection initializer
//student list





//Atleast one element
/*Console.WriteLine(numbers.Single());
Console.WriteLine(numbers.SingleOrDefault());*/

//Console.WriteLine(numbers.First());
//Console.WriteLine(numbers.FirstOrDefault());


//Console.WriteLine(numbers.Last());
//Console.WriteLine(numbers.LastOrDefault());



//Console.WriteLine(numbers.ElementAt(2));
//Console.WriteLine(numbers.ElementAtOrDefault(10));


//avoiding duplicates
/*var distinctNumbers = numbers.Distinct();
foreach (var number in distinctNumbers)
{
    Console.WriteLine(number);
}*/


//Aggregate functions
/*Console.WriteLine(numbers.Sum());
Console.WriteLine(numbers.Average());
Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.LongCount());
Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.LongLength);

Console.WriteLine(numbers.Max());
Console.WriteLine(numbers.Min());*/

//Console.WriteLine(numbers.Contains(10));



//Part 2



/*var totalSum = numbers.Aggregate((a, b) => a + b);
Console.WriteLine(totalSum);*/

//{ 10, 20, 30, 40, 50 }
//{ 50, 60}
/*var concatNumbers = numbers.Concat(new int[] { 50, 60 });
foreach (var item in concatNumbers)
{
    Console.WriteLine(item);
}*/

//{ 10, 20, 30, 40, 50, 50, 60 }
/*var numbers2 = new int[] { 60, 70, 80, 90, 100 };

var unionNumbers = concatNumbers.Union(numbers2);
foreach (var item in unionNumbers)
{
    Console.WriteLine(item);
}*/
//{ 10, 20, 30, 40, 50, 50, 60, 70, 80, 90, 100 }

/*Console.WriteLine("intersect numbers ========================");

var intersectNumbers = unionNumbers.Intersect(new int[] { 50,60});
foreach (var item in intersectNumbers)
{
    Console.WriteLine(item);
}*/
//output - {50, 60}


/*var exceptAllNumbers = unionNumbers.Except(new int[] { 50, 60 });
foreach (var item in exceptAllNumbers)
{
    Console.WriteLine(item);
}*/
//output - {10, 20, 30, 40, 50, 70, 80, 90, 100}

//{ 10, 20, 30, 40, 50 }

/*var take5 = numbers.Take(5);
foreach (var item in take5)
{
    Console.WriteLine(item);
}

var skipFirst5 = numbers.Skip(5);
foreach (var item in skipFirst5)
{
    Console.WriteLine(item);
}

var rangeArray = Enumerable.Range(1, 1000);
var same5050Times = Enumerable.Repeat(10, 50);
var emptyArray = Enumerable.Empty<int>();*/


//first, firstordefault
//last, lastordefault
//elementat, elementatordefault
//single, singleordefault,

//aggregate methods - sum, average, max, min, count(longcount), length

//Union, Intersect, Except - will give you all the elements except what you provided in the second array

//Contains - find 
//concat - merge
//distinct - finding unique elements

//Take, TakeWhile, Skip and SkipWhile, --- TakeLast, SkipLast????

var numbers = new int[] { 5, 20, 30, 40, 50 };


/*var allEvenNumbers = numbers.All(number => number % 2 == 0);

var atleastOneElement = numbers.Any();


var atleastOne10 = numbers.Any(number => number == 10);


var defaultIfEmpty = numbers.DefaultIfEmpty();
var noElementThen10 = numbers.DefaultIfEmpty(10);

var lowerBound = numbers.GetLowerBound(0);
Console.WriteLine(lowerBound);
var upperBound = numbers.GetUpperBound(0);
Console.WriteLine(upperBound);*/


/*var selectedNumbersWithText = numbers.Select(number => number.ToString() + " test");
foreach (var item in selectedNumbersWithText)
{
    Console.WriteLine(item);
}*/

//Take Until the condition is true

var students = new List<Student> {
new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

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
new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Aman",LastName="Asati",Age=30, Gender="M", TeamName="D" }
};



//First, FirstOrDefault, Last, LastOrDefault, ElementAt, ElementAtOrDefault, Single, SingleOrDefault, Aggregate, All, Any
//only one element, if no element it will return default, if more than one, run time exception

var studentMuskan = students.SingleOrDefault(student => student.FirstName == "Muskan");

Console.WriteLine(studentMuskan.ToString());

var firstStudent = students.FirstOrDefault();

Console.WriteLine(firstStudent.ToString());

var lastStudent = students.LastOrDefault();

Console.WriteLine(lastStudent.ToString());

Console.WriteLine(students.ElementAtOrDefault(10).ToString());

//Aggregate
var nameString = students.Aggregate<Student, string>("Student Names:", (str, student) => str + ", " + student.FirstName);
Console.WriteLine(nameString);

//All
var allAreCrossed18 = students.All(student => student.Age > 18);
Console.WriteLine("allAreCrossed18- " + allAreCrossed18);

//Any
var anyOneCrossed25 = students.Any(student => student.Age > 25);
Console.WriteLine("anyOneCrossed25- " + anyOneCrossed25);


//Contains And Append
Console.WriteLine("contains && append-----------------------");



var studentRajeev = new Student { FirstName = "Rajeev", LastName = "Kumar", Gender = "M", Age = 35 };



if (!students.Contains(studentRajeev, new StudentEqualityComparer()))
{
    var afterAppend = students.Append(studentRajeev);
    foreach (var item in afterAppend)
    {
        Console.WriteLine(item.FirstName);
    }
}
Console.WriteLine("contains && append-----------------------");


//Distinct && Concat, ConvertAll
Console.WriteLine("distinct--------------------");


var distinctStudents = students.Distinct(new StudentEqualityComparer());

foreach (var item in distinctStudents)
{
    Console.WriteLine(item.FirstName);
}
Console.WriteLine("distinct--------------------");

//Concat
var mithra = new Student { FirstName = "Mithra", LastName = "Rajeev Kumar", Gender = "F", Age = 6 };
var anotherStudentList = new List<Student> { mithra };

var afterConcat = students.Concat(anotherStudentList);
Console.WriteLine("Concat-----------------------");
foreach (var item in afterConcat)
{
    Console.WriteLine(item.FirstName);
}
Console.WriteLine("Concat-----------------------");

//ConvertAll
var getFirstNameAndLastName = students.ConvertAll(student => student.FirstName + " " + student.LastName + " " + student.Age);
Console.WriteLine("ConvertAll-----------------------");

foreach (var item in getFirstNameAndLastName)
{
    Console.WriteLine(item);
}
Console.WriteLine("ConvertAll-----------------------");


//Take, TakeLast and TakeWhile
var first2Students = students.Take(2);
var take5From5to10 = students.Take(new Range(5, 10));
var takeLast5Students = students.TakeLast(5);
var ABatchStudents = students.TakeWhile(student => student.TeamName == "A");
Console.WriteLine("TakeWhile - A Batch students..................");
foreach (var item in ABatchStudents)
{
    Console.WriteLine(item.FirstName);
}
Console.WriteLine("TakeWhile - A Batch students..................");

//Take Last 5 && Skip Last 5

//Skip, SkipLast and SkipWhile
var skipFirst20 = students.Skip(20);
var onlyABCBatchStudents = students.SkipLast(5);
var BCDBatchStudents = students.SkipWhile(student => student.TeamName == "A");
Console.WriteLine("SkipWhile - A Batch students..................");
foreach (var item in BCDBatchStudents)
{
    Console.WriteLine(item.FirstName);
}
Console.WriteLine("SkipWhile - A Batch students..................");

//Union, Intersect and Except
var ABatch = new[] {
new Student{FirstName="Amara",LastName="Sriram",Age=21, TeamName="A" },
new Student{FirstName="Muskan",LastName="Muskan",Age=20, TeamName="A" },
new Student{FirstName="Rahul",LastName="Yadav",Age=21, TeamName="A" },
new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, TeamName="A" },
new Student{FirstName="Aishwarya",LastName="Verma",Age=20, TeamName="A" }};

var BBatch = new[] {
new Student{FirstName="Shreya",LastName="",Age=20, TeamName="B" },
new Student{FirstName="Nandhita",LastName="",Age=20, TeamName="B" },
new Student{FirstName="Shashwat",LastName="",Age=20, TeamName="B" },
new Student{FirstName="Siddarth",LastName="",Age=21, TeamName="B" },
new Student{FirstName="Shriya",LastName="",Age=20, TeamName="B" }};

var AandB = ABatch.Union(BBatch);

var IntersectAandB = ABatch.Intersect(BBatch, new StudentEqualityComparer());

var ASubSetStudents = new Student[]{
    new Student { FirstName = "Shraddha", LastName = "Shraddha", Age = 20, TeamName = "A" },
    new Student { FirstName = "Aishwarya", LastName = "Verma", Age = 20, TeamName = "A" } };

var exceptStudents = ABatch.Except(ASubSetStudents, new StudentEqualityComparer());

//Where, OrderBy, OrderByDescending, ThenBy, GroupBy, Join, Select

var DBatchStudents = students.Where(student => student.TeamName == "D");

Console.WriteLine("D Batch Male Startwith V Student...");
foreach (var item in DBatchStudents)
{
    Console.WriteLine(item.ToString());
}


var BandCOnlyFemaleStudents = students.Where(student => ((student.TeamName == "B" || student.TeamName == "C") && student.Gender == "F"));

//1. name starts with "S"
//2. Who are all with empty lastname
//3. only Gender = "M" and order by firstname
//4. filter students from B and D and Age 21
Console.WriteLine("Name Starts with 'S' .....................");

var NameStartsWithS = students.Where(students => students.FirstName.ToLower().StartsWith('s'));
foreach(var item in NameStartsWithS) {
    Console.WriteLine(item.FirstName);

}

Console.WriteLine(" who are all with Empty Last Name.................... ");

var EmptyLastName = students.Where(students => students.LastName=="");
foreach(var item in EmptyLastName)
{
    Console.WriteLine(item.FirstName +" "+ item.LastName);
}

Console.WriteLine("only Gender and order by firstname ..................");

var OrderByGenderAndFirstName = students.Where(students => students.Gender == "M").OrderBy(students => students.FirstName);
foreach (var item in OrderByGenderAndFirstName)
{
    Console.WriteLine(item.FirstName +" "+item.LastName);

}

Console.WriteLine("filter students from B and D and Age 21.............");

var StudentsFromBD=students.Where(students => (students.TeamName == "B" || students.TeamName=="D") && students.Age==21 );
foreach(var item in StudentsFromBD)
{
    Console.WriteLine(item.FirstName +" "+ item.LastName);
}

//5. male students count in each team
//6. famale students count in each team
//7. take students between 6 to 12 and who are all having age = 20 and show their firstname and lastname
//8. print all the students firstname and age
//9. how many students are having age 21 print their name and teamname
//10. filter students first name starts with "P", "T" and "N"

Console.WriteLine("Male Students Count...........");

var CountMaleStudents = students.Where(x => x.Gender == "M") ;
var countStudents=CountMaleStudents.Count();
Console.WriteLine(countStudents);

Console.WriteLine("FeMale Students Count...........");

var CountFemaleStudents = students.Where(x => x.Gender == "F");
var CountStudents2=CountFemaleStudents.Count();
Console.WriteLine(CountStudents2);

Console.WriteLine("Between 6 to 12.............");

var Student6To12 = students.Where(students => students.Age == 20).Take(new Range(6,12));
foreach(var item in Student6To12)
{ 
    Console.WriteLine(item.FirstName+ " "+ item.LastName);
}

Console.WriteLine("Printing all the students Name and age...............");

var result=students.Select(x => new { x.FirstName, x.Age });
foreach(var item in result) 
{
    Console.WriteLine(item.FirstName + " " + item.Age); 
}

Console.WriteLine("Age is 21...............");
var result2 =students.Where(students => students.Age == 21);
foreach(var i in result2)
{
    Console.WriteLine(i.FirstName + " " + i.TeamName);
}
Console.WriteLine("Filter Students P, T, N");
var result3=students.Where(students => (students.FirstName.ToLower().StartsWith('t') || students.FirstName.ToLower().StartsWith('p') || students.FirstName.ToLower().StartsWith('n')));

foreach(var i in result3)
{
    Console.WriteLine(i.FirstName);
}
var Number = new[] { 1, 2, 3 };

List<int> number = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

/*Question1 - filter the number< 3 and >8
Question2 - how many numbers are <3 and > 8 in above lists
Question3 - find out all the even numbers
Question4 - find the 3rd highest and 4th lowest*/
Console.WriteLine("Numbers.........................");
var result4=number.Skip(3).Take(3).Select(x => new { x });
foreach(var i in result4)
{
    Console.WriteLine(i);
}
Console.WriteLine("Count of number from 3 to 8............");
var result5=result4.Count();
Console.WriteLine(result5);

Console.WriteLine("Even Numbers.............");
var result6=number.Where(x => x %2 ==0);

foreach(var i in result6)
{
    Console.WriteLine(i);
}

Console.WriteLine("3rd highest............");
var thirdLargest=number.OrderByDescending(x => x).ElementAt(2);
Console.WriteLine(thirdLargest);

Console.WriteLine("4th lowest...........");
var fourth=number.OrderBy(x => x).ElementAt(3);
Console.WriteLine(fourth);



//students.Where(students =>((students.FirstName.ToLower() == 's') && (students.LastName="") && (students.Gender="M").OrderBy(students =>stude));

var DBatchStudentsOrderByLastName = students.Where(student => student.TeamName == "D")
    .OrderBy(student => student.LastName);

Console.WriteLine("D Batch Order By Descending - LastName-----------------");

var DBatchStudentsOrderByDescFirstName = students.Where(student => student.TeamName == "D")
    .OrderByDescending(student => student.FirstName)
    .ThenBy(student => student.Age);
foreach (var item in DBatchStudentsOrderByDescFirstName)
{
    Console.WriteLine(item.ToString());
}

var DBatchStudentsOrderByDescLastNameThenByAge = students
    .Where(student => student.TeamName == "D")
    .OrderByDescending(student => student.LastName)
    .ThenByDescending(student => student.Age);

Console.WriteLine("D Batch Order By Descending - LastName-----------------");

Console.WriteLine("Group By-------------------------");

//I used GroupBy extension method on students, student => TeamName By
var groupedStudents = students.GroupBy(student => student.TeamName);

foreach (var group in groupedStudents)
{
    //Each group now have key - A, B, C and D
    Console.WriteLine(group.Key + ".....Count: " + group.Count());


    var maleStudents = group.Where(student => student.Gender == "M");

    Console.WriteLine("Male Count: " + maleStudents.Count());
    foreach (var item in maleStudents)
    {
        Console.WriteLine(item.FirstName + " " + item.LastName);
    }
    var femaleStudents = group.Where(student => student.Gender == "F");
    Console.WriteLine("Female Count: " + femaleStudents.Count());
    foreach (var item in femaleStudents)
    {
        Console.WriteLine(item.FirstName + " " + item.LastName);
    }
}
Console.WriteLine("Group By-------------------------");


//First, Last, ElementAt, Single, All, Any, Take, TakeLast, TakeWhile, Skip, SkipLast, SkipWhile,
//Union, Intersect, Except
//Contains, Append, Concat, Distinct
//Where, OrderBy, OrderByDescending, ThenBy, ThenByDescending, GroupBy, Join, Select
//Sum, Average, Count, Max, Min

var maxAgeStudent = students.Max(student => student.Age);

Console.WriteLine("select query ..................");
var studentFirstNameAndAge = students
    .Where(student => student.TeamName == "C")
    .Select(student => new { student.FirstName, student.Age })
    .OrderByDescending(student => student.Age);
foreach (var item in studentFirstNameAndAge)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("select query ..................");



//Select, Anonymous Type, var keyword
var onlyNameAndAge = students.Where(student => (student.TeamName == "B" && student.TeamName == "C"))
    .Select(student => new { student.FirstName, student.Age });

















class Student
{
    /*    private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/

    //Auto implemented properties - ILDASM
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string TeamName { get; set; }

    public string ToString()
    {
        return (this.FirstName + " " + this.LastName + " " + this.Age + " " + this.TeamName);
    }

}

class StudentFirstNameWithAge
{
    public string FirstName { get; set; }
    public int Age { get; set; }
}

class StudentEqualityComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.FirstName == y.FirstName && x.LastName == y.LastName;
    }

    public int GetHashCode(Student obj)
    {
        return obj.Age.GetHashCode();
    }
}

class Test
{
    /*  public bool isEven(int number)
      {
          return number % 2 == 0;
      }

      delegate (int number){
          return number % 2 == 0;
      };

     


      public int Add(int a, int b)
      {
          return a + b;
      }

      delegate (int a, int b)
      {
          return a + b;
      };

      (a, b) => a + b;*/

    /*public void Print()
    {
        Console.WriteLine("Print");
    }

    delegate (){
         Console.WriteLine("Print");
    }

    () => Console.WriteLine("Print");

    number => number % 2 == 0;

    (a, b) => a + b;

(int a ,int b, int c) =>
{
    Console.WriteLine(a);
    Console.WriteLine(b);
    int result = a + b;
    return result;
}*/



}




