//Lab_13
//Part-A
//1 Create an index on the company field in the stocks collection.
db.Stock.createIndex({company:1}) 
//2 Create a compound index on the sector and sales fields in the stocks collection.
db.Stock.createIndex({sector:1,sales:1})
//3 List all the indexes created on the stocks collection. 
db.Stock.getIndexes()
//4 Drop an existing index on the company field from the stocks collection. 
db.Stock.dropIndex("company_1")
//5 Use a cursor to retrieve and iterate over documents in the stocks collection, displaying each document.
var cursor = db.Stock.find()
cursor 
//6 Limit the number of documents returned by a cursor to the first 3 documents in the stocks collection. 
var cursor = db.Stock.find().limit(3)
cursor
//7 Sort the documents returned by a cursor in descending order based on the sales field. 
var cursor = db.Stock.find().sort({sales:-1})
cursor
//8 Skip the first 2 documents in the result set and return the next documents using the cursor. 
var cursor = db.Stock.find().skip(2)
cursor
//9 Convert the cursor to an array and return all documents from the stocks collection. 
var cursor = db.Stock.find().toArray()
cursor
//10 Create a collection named "Companies" with schema validation to ensure that each document must contains a company field (string) and a sector field (string).
db.createCollection("Companies",{
    validator:{
        $jsonSchema:{
        bsonType:'object',
        required:["company","sector"],
        properties:{
            company:{bsonType:"string"},
            sector:{bsonType:"string"}
    }
    }
    }
    })

//Part-B
//1 Create a collection named "Scripts" with validation for fields like eps, pe, and roe to ensure that they are numbers and required/compulsory fields.
db.createCollection("Scripts",{
	validator:{
        $jsonSchema:{
            bsonType:'object',
            required:["eps","pe","roe"],
            properties:{
                eps:{bsonType:"double"},
                pe:{bsonType:"double"},
                roe:{bsonType:"double"}
    }
    }
    }
    })
//2 Create a collection named "Products" where each product has an embedded document for manufacturer details and a multivalued field for categories that stores an array of category names the product belongs to. 
//. manufacturer details: The manufacturer will be an embedded document with fields like name, 
//country, and establishedYear. 
//. categories: The categories will be an array field that holds multiple values. (i.e. Electronics, 
//Mobile, Smart Devices). 
db.createCollection("Products", {
    validator: {
       $jsonSchema: {
          bsonType: "object",
          required: ["name", "price", "manufacturer", "categories"],
          properties: {
             name: { bsonType: "string" },
             price: { bsonType: "double" },
             manufacturer: {
                bsonType: "object",
                required: ["name", "country", "establishedYear"],
                properties: {
                   name: { bsonType: "string" },
                   country: { bsonType: "string" },
                   establishedYear: { bsonType: "int" }
                }
             },
             categories: {
                bsonType: "array",
                minItems: 1,
                items: { bsonType: "string" }
             }
          }
       }
    }
 });
 
//Part-C
//1 Create a collection named “financial_Reports” that requires revenue (a positive number) but allows optional fields like expenses and netIncome (if provided, they should also be numbers). 
db.createCollection("financial_Reports",{
	validator:{
	$jsonSchema:{
		bsonType:"object",
		required:["revenue"],
		properties:{
			revenue:{bsonType:"double",minimum:0.01},
			expenses:{bsonType:"double"},
			netIncome:{bsonType:"double"}
}
}
}
})
//2 Create a collection named "Student" where each student has name and address are embedded document and mobilenumber and emailaddress are multivalued field that stores an array of values. 
db.createCollection("Student", {
    validator: {
       $jsonSchema: {
          bsonType: "object",
          required: ["name", "address", "mobileNumber", "emailAddress"],
          properties: {
             name: {
                bsonType: "object",
                required: ["firstName", "lastName"],
                properties: {
                   firstName: { bsonType: "string" },
                   lastName: { bsonType: "string" }
                }
             },
             address: {
                bsonType: "object",
                required: ["street", "city", "state", "zipCode"],
                properties: {
                   street: { bsonType: "string" },
                   city: { bsonType: "string" },
                   state: { bsonType: "string" },
                   zipCode: { bsonType: "string" }
                }
             },
             mobileNumber: {
                bsonType: "array",
                minItems: 1,
                items: { bsonType: "string" }
             },
             emailAddress: {
                bsonType: "array",
                minItems: 1,
                items: { bsonType: "string" }
             }
          }
       }
    }
 });