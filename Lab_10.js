//Part-A
//1
db.Student.updateOne({name:"John"},{$set:{age:31}})
//2
db.Student.updateMany({city:"New York"},{$set:{city:"New Jersey"}})
//3
db.Student.updateMany({age : {$gt:35}},{$set:{isActive:false}})
//4
db.Student.updateMany({},{$inc:{age:1}})
//5
db.Student.updateMany({name:"Eva"},{$set:{name:"Cambridge"}})
//6
db.Student.updateMany({name:'Sophia'},{$set:{isActive:false}})
//7
db.Student.updateMany({age:{$lt:30}},{$set:{city:'San Diego'}})
//8
db.Student.updateMany({},{$rename:{age:'years'}})
//9
db.Student.updateMany({name:'Nick'},{$set:{isActive:true}})
//10
db.Student.updateMany({},{$set:{country:'USA'}})
//11
db.Student.updateMany({name:'David'},{$set:{city:'Orlando'}})
//12
db.Student.updateMany({},{$mul:{years:2}})
//13
db.Student.updateMany({name:'Tom'},{$unset:{city:""}})
//14
db.Student.updateMany({years:{$gt:30}},{$set:{premiumUser:true}})
//15
db.Student.updateMany({name:'Jane'},{$set:{isActive:true}})
//16
db.Student.updateMany({name:'Lucy'},{$set:{isActive:false}})
//17
db.Student.deleteOne({name:'Nick'})
//18
db.Student.deleteMany({isActive:false})
//19
db.Student.deleteMany({city:'New York'})
//20
db.Student.deleteMany({years:{$gt:35}})
//21
db.Student.deleteMany({name:'Olivia'})
//22
db.Student.deleteMany({years:{$lt:25}})
//23
db.Student.deleteOne({isActive:true})
//24
db.Student.deleteMany({city:'Los Angeles'})
//25
db.Student.deleteMany({city: {$exists: false}})
//26
db.Student.updateMany({},{$rename:{city:'location'}})
//27
db.Student.updateMany({name:'John'},{$rename:{name:'Fullname'}})
//28
db.Student.updateMany({},{$rename:{isActive:'status'}})
//29
db.Student.updateMany({city:'San Francisco'},{$rename:{age:'yearsOld'}})
//30
db.createCollection("Employee", {
    capped: true,
    size: 5120,
    max: 100,
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["Ecode", "Ename"],
            properties: {
                Ecode: {
                    bsonType: "int"
                },
                Ename: {
                    bsonType: "string"
                },
                Age: {
                    bsonType: "int"
                },
                City: {
                    bsonType: "string"
                }
            }
        }
    }
});

db.Employee.insertMany([
    {"Ecode": 1, "Ename": "John"},
    {"Ecode": 2, "Ename": "Jane", "Age": 25, "City": "Los Angeles"},
    {"Ecode": 3, "Ename": "Tom", "Age": 35},
    {"Ecode": 4, "Ename": "Lucy", "Age": 28, "City": "San Francisco"},
    {"Ecode": 5,"Ename": "Dino"}
]);
