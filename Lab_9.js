//Part-B
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