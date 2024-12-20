//Part-A
use BANK_INFO
db.createCollection("Deposit")
db.Deposit.insertMany([
  {
    "ACTNO": 101,
    "CNAME": "ANIL",
    "BNAME": "VRCE",
    "AMOUNT": 1000,
    "ADATE": "1995-03-01"
  },
  {
    "ACTNO": 102,
    "CNAME": "SUNIL",
    "BNAME": "AJNI",
    "AMOUNT": 5000,
    "ADATE": "1996-01-04"
  },
  {
    "ACTNO": 103,
    "CNAME": "MEHUL",
    "BNAME": "KAROLBAGH",
    "AMOUNT": 3500,
    "ADATE": "1995-11-17"
  },
  {
    "ACTNO": 104,
    "CNAME": "MADHURI",
    "BNAME": "CHANDI",
    "AMOUNT": 1200,
    "ADATE": "1995-12-17"
  },
  {
    "ACTNO": 105,
    "CNAME": "PRMOD",
    "BNAME": "M.G. ROAD",
    "AMOUNT": 3000,
    "ADATE": "1996-03-27"
  },
  {
    "ACTNO": 106,
    "CNAME": "SANDIP",
    "BNAME": "ANDHERI",
    "AMOUNT": 2000,
    "ADATE": "1996-03-31"
  },
  {
    "ACTNO": 107,
    "CNAME": "SHIVANI",
    "BNAME": "VIRAR",
    "AMOUNT": 1000,
    "ADATE": "1995-09-05"
  },
  {
    "ACTNO": 108,
    "CNAME": "KRANTI",
    "BNAME": "NEHRU PLACE",
    "AMOUNT": 5000,
    "ADATE": "1995-07-02"
  }
]
)
//1
db.Deposit.find()
//2
db.Deposit.findOne()
//3
db.Deposit.insertOne({ACTNO: 109,CNAME:'KIRTI',BNAME:'VIRAR',AMOUNT:'3000',ADATE:'1997-05-03'})
//4
db.Deposit.insertMany([{ACTNO:110,CNAME:'MITALI',BNAME:'ANDHERI',AMOUNT:4500,ADATE:'1995-09-04'},{ACTNO:111,CNAME:'RAJIV',BNAME:'NEHRU PLACE',AMOUNT:7000,ADATE:'1998-10-02'}])
//5
db.Deposit.find({BNAME:'VIRAR'})
//6
db.Deposit.find({AMOUNT : {$gte : 3000,$lte : 5000}})
//7
db.Deposit.find({AMOUNT:{$gt:2000},BNAME:'VIRAR'})
//8
db.Deposit.find({},{CNAME:1,BNAME:1,AMOUNT:1,_id:0})
//9
db.Deposit.find().sort({CNAME:1})
//10
db.Deposit.find().sort({BNAME:-1})
//11
db.Deposit.find().sort({ACTNO:1,AMOUNT:-1})
//12
db.Deposit.find().limit(2)
//13
db.Deposit.find().skip(2).limit(1)
//14
db.Deposit.find().skip(5).limit(2)
//15
db.Deposit.countDocuments()

//Part-B
//1
db.Student.insertMany([{ "_id": 1, "name": "John", "age": 30, "city": "New York", "isActive": true }, 
  { "_id": 2, "name": "Jane", "age": 25, "city": "Los Angeles", "isActive": false }, 
  { "_id": 3, "name": "Tom", "age": 35, "city": "Chicago", "isActive": true }, 
  { "_id": 4, "name": "Lucy", "age": 28, "city": "San Francisco", "isActive": true }, 
  { "_id": 5, "name": "David", "age": 40, "city": "Miami", "isActive": false }, 
  { "_id": 6, "name": "Eva", "age": 23, "city": "Boston", "isActive": true }, 
  { "_id": 7, "name": "Nick", "age": 38, "city": "Seattle", "isActive": false }, 
  { "_id": 8, "name": "Sophia", "age": 27, "city": "New York", "isActive": true }, 
  { "_id": 9, "name": "Liam", "age": 32, "city": "Los Angeles", "isActive": false }, 
  { "_id": 10, "name": "Olivia", "age": 29, "city": "San Diego", "isActive": true } ])
//2
db.Student.find()
//3
db.Student.find({age:30})
//4
db.Student.find({age:{$gt:25}})
//5
db.Student.find({$and : [{name:'John'},{age:30}]})
//6
db.Student.find({age:{$ne:25}})
//7
//Using $or
db.Student.find({$or:[{age:25},{age:30},{age:35}]})
//Using $in
 db.Student.find({age:{$in:[25,30,35]}})
 //8
 db.Student.find({$or : [{name:'John',age:30}]})
 //9
 db.Student.find({name:'John',city:'New York'})
 //10
 db.Student.find({name:'John',city:'New York'},{name:1,age:1,_id:0})
