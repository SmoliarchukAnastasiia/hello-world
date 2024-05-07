using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;


var dbClient = new MongoClient("mongodb://localhost:27017");
IMongoDatabase db = dbClient.GetDatabase("mydb");
var emp = db.GetCollection<BsonDocument>("testkr1");


var documents = emp.Find(new BsonDocument()).ToList();

//foreach (BsonDocument doc in documents)
//{
//    Console.WriteLine(doc.ToString());
//}
//public class Object;
//{
//     public int _id { get; set; };

//      public string Object { get; set; };
//}

