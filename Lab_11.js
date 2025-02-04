//Part-A
db.createCollection("employee")
db.employee.insertMany([
    {
      EID: 1,
      ENAME: "Nick",
      GENDER: "Male",
      JOININGDATE: "2013-01-01",
      SALARY: 4000,
      CITY: "London"
    },
    {
      EID: 2,
      ENAME: "Julian",
      GENDER: "Female",
      JOININGDATE: "2014-10-01",
      SALARY: 3000,
      CITY: "New York"
    },
    {
      EID: 3,
      ENAME: "Roy",
      GENDER: "Male",
      JOININGDATE: "2016-06-01",
      SALARY: 3500,
      CITY: "London"
    },
    {
      EID: 4,
      ENAME: "Tom",
      GENDER: "Male",
      JOININGDATE: null,
      SALARY: 4500,
      CITY: "London"
    },
    {
      EID: 5,
      ENAME: "Jerry",
      GENDER: "Male",
      JOININGDATE: "2013-02-01",
      SALARY: 2800,
      CITY: "Sydney"
    },
    {
      EID: 6,
      ENAME: "Philip",
      GENDER: "Male",
      JOININGDATE: "2015-01-01",
      SALARY: 7000,
      CITY: "New York"
    },
    {
      EID: 7,
      ENAME: "Sara",
      GENDER: "Female",
      JOININGDATE: "2017-08-01",
      SALARY: 4800,
      CITY: "Sydney"
    },
    {
      EID: 8,
      ENAME: "Emily",
      GENDER: "Female",
      JOININGDATE: "2015-01-01",
      SALARY: 5500,
      CITY: "New York"
    },
    {
      EID: 9,
      ENAME: "Michael",
      GENDER: "Male",
      JOININGDATE: null,
      SALARY: 6500,
      CITY: "London"
    },
    {
      EID: 10,
      ENAME: "John",
      GENDER: "Male",
      JOININGDATE: "2015-01-01",
      SALARY: 8800,
      CITY: "London"
    }
  ]);
//1
db.employee.find({ENAME:/^E/})
//2
db.employee.find({ENAME:/n$/})
//3
db.employee.find({ENAME:/^[S,M]/})
//4
db.employee.find({CITY:/^[A-M]/})
//5
db.employee.find({CITY:/ney$/})
//6
db.employee.find({ENAME:/n/i})
//7
db.employee.find({ENAME:/^E.{4}/})
//8
db.employee.find({ENAME:/^S.*a$/})
//9
db.employee.find({ENAME:/^Phi/},{_id:0,EID:1,ENAME:1,CITY:1,SALARY:1})
//10
db.employee.find({CITY:/dne/},{_id:0,ENAME:1,JOININGDATE:1,CITY:1})
//11
db.employee.find({CITY:{$nin:['London','Sydney']}},{_id:0,ENAME:1,JOININGDATE:1,CITY:1})
//12
db.employee.find({ENAME:/^J/})
//13
db.employee.find({ENAME:/y$/})
//14
db.employee.find({ENAME:/a/})
//15
db.employee.find({ENAME:/[a,e]/})
//16
db.employee.find({ENAME:/^J.*n$/})
//17
db.employee.find({CITY:/^New/})
//18
db.employee.find({CITY:{$not:/^L/}})
//19
db.employee.find({CITY:/York/})
//20
db.employee.find({ENAME:/[aeiou]{2}/i})
//21
db.employee.find({ENAME:/^.{3,}$/})
//22
db.employee.find({ENAME:/^.{4}$/})
//23
db.employee.find({ENAME:/^[S,M]/})
//24
db.employee.find({ENAME:/il/})
//25
db.employee.find({ENAME:{$not:/a/}})
//26
db.employee.find({ENAME:/\d/})
//27
db.employee.find({ENAME:/^[^aeiou]*[aeiou][^aeiou]*$/i})
//28
db.employee.find({ENAME:/^[A-Z][a-z]/})

//Part-B
db.createCollection("Student")
db.Student.insertMany([
    {
      ROLLNO: 101,
      SNAME: "Vina",
      DEPARTMENT: "CE",
      FEES: 15000,
      SEM: 3,
      GENDER: "Female",
      CITY: "Rajkot"
    },
    {
      ROLLNO: 102,
      SNAME: "Krisha",
      DEPARTMENT: "EC",
      FEES: 8000,
      SEM: 5,
      GENDER: "Female",
      CITY: "Ahmedabad"
    },
    {
      ROLLNO: 103,
      SNAME: "Priti",
      DEPARTMENT: "Civil",
      FEES: 12000,
      SEM: 7,
      GENDER: "Female",
      CITY: "Baroda"
    },
    {
      ROLLNO: 104,
      SNAME: "Mitul",
      DEPARTMENT: "CE",
      FEES: 15000,
      SEM: 3,
      GENDER: "Male",
      CITY: "Rajkot"
    },
    {
      ROLLNO: 105,
      SNAME: "Keshav",
      DEPARTMENT: "CE",
      FEES: 15000,
      SEM: 3,
      GENDER: "Male",
      CITY: "Jamnagar"
    },
    {
      ROLLNO: 106,
      SNAME: "Zarna",
      DEPARTMENT: "Civil",
      FEES: 12000,
      SEM: 5,
      GENDER: "Female",
      CITY: "Ahmedabad"
    },
    {
      ROLLNO: 107,
      SNAME: "Nima",
      DEPARTMENT: "EE",
      FEES: 9000,
      SEM: 5,
      GENDER: "Female",
      CITY: "Rajkot"
    },
    {
      ROLLNO: 108,
      SNAME: "Dhruv",
      DEPARTMENT: "Mechanical",
      FEES: 10000,
      SEM: 5,
      GENDER: "Male",
      CITY: "Rajkot"
    },
    {
      ROLLNO: 109,
      SNAME: "Krish",
      DEPARTMENT: "Mechanical",
      FEES: 10000,
      SEM: 7,
      GENDER: "Male",
      CITY: "Baroda"
    },
    {
      ROLLNO: 110,
      SNAME: "Zeel",
      DEPARTMENT: "EE",
      FEES: 9000,
      SEM: 3,
      GENDER: "Female",
      CITY: "Jamnagar"
    }
  ]);
use Student
//1
db.Student.find({SNAME:/^K/})
//2
db.Student.find({SNAME:/^[Z,D]/})
//3
db.Student.find({CITY:/^[A-R]/})
//4
db.Student.find({SNAME:/^P.*i$/})
//5
db.Student.find({DEPARTMENT:/^C/})
//6
db.Student.find({CITY:/med/},{_id:0,SNAME:1,SEM:1,FEES:1,DEPARTMENT:1})
//7
db.Student.find({CITY:{$nin:['Rajkot','Baroda']}},{_id:0,SNAME:1,SEM:1,FEES:1,DEPARTMENT:1})
//8
db.Student.find({SNAME:/^K.*/})
//9
db.Student.find({SNAME:/a$/})
//10
db.Student.find({SNAME:/ri/i})

//Part-C
//1
db.Student.find({SNAME:/[A,E,I,O,U]/})
//2
db.Student.find({CITY:/(pur|bad)$/})
//3
db.Student.aggregate([
    {
      $addFields: {
        feesStr: { $toString: "$FEES" }
      }
    },
    {
      $match: {
        feesStr:  /^1/
      }
    }
  ])
//4
db.Student.find({SNAME:/^[K,V]/})
//5
db.Student.find({CITY:/^.{5}$/})
//6
db.Student.find({SNAME:{$not:/e/}})
//7
db.Student.find({CITY:/^Ra.*ot$/})
//8
db.Student.find({SNAME:/^[^aeiou]*[aeiou][^aeiou]*$/i})
//9
db.Student.find({SNAME:/^(.).*\1$/})
//10
db.Student.find({DEPARTMENT:/^[C,E]/})
//11
db.Student.find({SNAME:/^.{5}$/})
//12
db.Student.find({$and:[{GENDER:'Female'},{CITY:/^A/}]})