using System.IO;  // include the System.IO namespace

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content


string storyText = "Daily winning story! Every morning, Sarah entered the office with a smile, ready to conquer the day. She tackled her tasks efficiently, always striving for excellence. By afternoon, she received praise from her boss for her exceptional performance. On her way home, Sarah treated herself to a relaxing walk in the park. That evening, she reflected on her achievements, feeling content and fulfilled";
File.WriteAllText("story.txt", storyText);

string readStory = File.ReadAllText("story.txt");
Console.WriteLine(readStory);