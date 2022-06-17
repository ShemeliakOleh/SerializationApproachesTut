

using SerializationApproaches;

Person person = new() { FirstName = "Ivan", Age = 27 };



Serializer serializer = new Serializer();

//Binary Serialization
//string binaryFilePath = "binarydata.txt";
//serializer.SerializeToFileAsBinary(person, binaryFilePath);
//var personFromBinaryFile = serializer.DeserializeFromFileAsBinary(binaryFilePath) as Person;
//Console.WriteLine(personFromBinaryFile);

//Xml Serialization
//string xmlFilePath = "xmldata.txt";
//serializer.SerializeToFileAsXml(typeof(Person), person, xmlFilePath);
//var personFromXmlFile = serializer.DeserializeFromFileAsXml(typeof(Person),xmlFilePath);
//Console.WriteLine(personFromXmlFile);

//Json Serialization
//string jsonFilePath = "jsondata.txt";
//serializer.SerializeToFileAsJson(typeof(Person), person, jsonFilePath);
//var personFromJsonFile = serializer.DeserializeFromFileAsJson(typeof(Person), jsonFilePath);
//Console.WriteLine(personFromJsonFile);

