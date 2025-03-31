using System.CodeDom.Compiler;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using Newtonsoft.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;



namespace sample1;

class Program
{
    static void Main(string[] args)
    {
        Personne Michel = new Personne {Nom = "Michel", Age=47};
        Console.WriteLine(Michel.Hello(true));
        Console.WriteLine(Michel.ToJson());
        /*
        int[] resizers = Enumerable.Range(1, 1000).ToArray();
        DateTime time1=DateTime.Now;
        Parallel.ForEach(resizers, (i) =>
        {
            using (Image image = Image.Load("/workspaces/AA-Serverless-NET/elephant.jpg")) {
                image.Mutate(x => x.Resize(image.Width / i, image.Height / i));
                image.Save($"bin/results/imageresized_{i}.png");
            }
        });
        Console.WriteLine($"Time taken in Parallel: {DateTime.Now-time1}");

        DateTime time2=DateTime.Now;
        foreach(int i in resizers)
        {
            using (Image image = Image.Load("/workspaces/AA-Serverless-NET/elephant.jpg")) {
                image.Mutate(x => x.Resize(image.Width / i, image.Height / i));
                image.Save($"bin/results/imageresized2_{i}.png");
            }
        };
        Console.WriteLine($"Time taken in Sequential: {DateTime.Now-time2}");
        */
        
    }
}

public class Personne { 
    required public string Nom { get; set; }
    required public int Age { get; set; }

    public string Hello(bool isLowercase){
        string str=$"hello {Nom}, you are {Age}";
        if(isLowercase){
            return(str.ToLower());
        }
        else{
            return(str.ToUpper());
        }
    }

    public string ToJson() {
        return JsonConvert.SerializeObject(this,Formatting.Indented);
        
     }
 }