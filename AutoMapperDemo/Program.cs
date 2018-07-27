using AutoMapper;
using Newtonsoft.Json;
using System;

namespace AutoMapperDemo
{
    /// <summary>
    /// Auto Mapper Example
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {          
            //Create a Map
            //InputDTO=>Model=>OutputData
            Mapper.Initialize(cfg => cfg.AddProfile<InputToOutputProfile>());

            InputOrder inputOrder = new InputOrder();
            InputOrder newInputOrder = inputOrder.BuildInputOrder();

            Console.WriteLine(JsonConvert.SerializeObject(newInputOrder,Formatting.Indented));

            OutputOrder outputOder = Mapper.Map<OutputOrder>(newInputOrder);
            Console.WriteLine(JsonConvert.SerializeObject(outputOder, Formatting.Indented));

            Console.ReadKey();

        }
    }
}
