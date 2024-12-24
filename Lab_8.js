//Part-A
//1
use Darshan
//2
use DIET
//3
show databases
//4
db
//5
db.dropDatabase()

use Darshan
//6
db.createCollection("Student")
//7
db.createCollection("Department")
//8
show collections
//9
db.Department.insertOne({Dname:"CE", HOD:"Patel"})
//10
db.Department.insertMany([{Dname:"IT"}, {Dname:"ICT"}])
//11
db.Department.drop()
//12
db.Student.insertOne({Name:"Aum",City:"Rajkot",Branch:"CSE",Semester:4,Age:20})
//13
db.Student.insertMany([{Name:"Nisarg",City:"Rajkot",Branch:"CSE",Semester:4,Age:19},{Name:"Deven",City:"Rajkot",Branch:"CSE",Semester:4,Age:19},{Name:"Darshan",City:"Rajkot",Branch:"CSE",Semester:4,Age:20}])
//14
db.getCollectionNames().includes("Student")
//15
db.Student.stats()
//16
db.Student.drop()
//17
db.createCollection("Deposit")
//18
db.Deposit.insertMany([{ ACTNO: 101, CNAME: 'ANIL', BNAME: 'VRCE', AMOUNT: 1000.00, CITY: 'RAJKOT' },
  { ACTNO: 102, CNAME: 'SUNIL', BNAME: 'AJNI', AMOUNT: 5000.00, CITY: 'SURAT' },
  { ACTNO: 103, CNAME: 'MEHUL', BNAME: 'KAROLBAGH', AMOUNT: 3500.00, CITY: 'BARODA' },
  { ACTNO: 104, CNAME: 'MADHURI', BNAME: 'CHANDI', AMOUNT: 1200.00, CITY: 'AHMEDABAD' },
  { ACTNO: 105, CNAME: 'PRMOD', BNAME: 'M.G. ROAD', AMOUNT: 3000.00, CITY: 'SURAT' },
  { ACTNO: 106, CNAME: 'SANDIP', BNAME: 'ANDHERI', AMOUNT: 2000.00, CITY: 'RAJKOT' },
  { ACTNO: 107, CNAME: 'SHIVANI', BNAME: 'VIRAR', AMOUNT: 1000.00, CITY: 'SURAT' },
  { ACTNO: 108, CNAME: 'KRANTI', BNAME: 'NEHRU PLACE', AMOUNT: 5000.00, CITY: 'RAJKOT' }
])
//19
db.Deposit.find()
//20
db.Deposit.drop()

//Part-B
//1
use Computer
//2
db.createCollection("Faculty")
//3
db.Faculty.insertOne({FID:1,FNAME:'ANIL',BNAME:'CE',SALARY:10000,JDATE:'1995-03-01'})
//4
db.Faculty.insertMany([{FID:2,FNAME:'SUNIL',BNAME:'CE',SALARY:50000,JDATE:'1996-01-04'},{FID:3,FNAME:'MEHUL',BNAME:'IT',SALARY:35000,JDATE:'1995-11-17'},{FID:4,FNAME:'MADHURI',BNAME:'IT',SALARY:12000,JDATE:'1995-12-17'},{FID:5,FNAME:'PRMOD',BNAME:'CE',SALARY:30000,JDATE:'1996-03-27'},{FID:6,FNAME:'SANDIP',BNAME:'CE',SALARY:20000,JDATE:'1996-03-31'},{FID:7,FNAME:'SHIVANI',BNAME:'CE',SALARY:10000,JDATE:'1995-09-05'},{FID:8,FNAME:'KRANTI',BNAME:'IT',SALARY:50000,JDATE:'1995-07-02'}])
//5
db.Faculty.find()
//6
db.Faculty.drop()
//7
db.Computer.drop()

//Part-C(Using UI)
//3
[{
    "FID":1,
    "FNAME":"ANIL",
    "BNAME":"CE",
    "SALARY":10000,
    "JDATE":"1995-03-01"
},
{
    "FID":2,
    "FNAME":"SUNIL",
    "BNAME":"CE",
    "SALARY":50000,
    "JDATE":"1996-01-04"
},
{
    "FID":3,
    "FNAME":"MEHUL",
    "BNAME":"IT",
    "SALARY":35000,
    "JDATE":"1995-11-17"
},
{
    "FID":4,
    "FNAME":"MADHURI",
    "BNAME":"IT",
    "SALARY":12000,
    "JDATE":"1995-12-17"
},
{
    "FID":5,
    "FNAME":"PRMOD",
    "BNAME":"CE",
    "SALARY":30000,
    "JDATE":"1996-03-27"
},
{
    "FID":6,
    "FNAME":"SANDIP",
    "BNAME":"CE",
    "SALARY":20000,
    "JDATE":"1996-03-31"
},
{
    "FID":7,
    "FNAME":"SHIVANI",
    "BNAME":"CE",
    "SALARY":10000,
    "JDATE":"1995-09-05"
},
{
    "FID":8,
    "FNAME":"KRANTI",
    "BNAME":"IT",
    "SALARY":50000,
    "JDATE":"1995-07-02"
}
]
