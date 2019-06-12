// ==============================================================================
//
//  This file is part of the Campusoft Loja Cia. Ltda. code samples.
//
//  Copyright (C) Campusoft Loja Cia. Ltda.  All rights reserved.
//
//  This source code is intended only as a supplement to Campusoft
//  Development Team.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// ===============================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

/// <summary>
/// Demonstrates how to GET records from REST API ELLUCIAN BANNER, save
/// those json records to a file or save individual records to json files.
/// If you want to run this sample repeatedly, you have to generate 
/// every 5 minutes the Auth Bearer Token on Postman.
/// POST to https://integrate.elluciancloud.com/auth
/// </summary>
/// 
namespace ConsoleAppBannerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonFromJson> personsFromBanner = new List<PersonFromJson>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "HerePutYourOwnBannerTokenCallYourBannerAdministrator");
            HttpResponseMessage response = client.GetAsync("https://integrate.elluciancloud.com/api/persons").Result;

            if (response.IsSuccessStatusCode)
            {
                string JSON = response.Content.ReadAsStringAsync().Result;
                personsFromBanner = JsonConvert.DeserializeObject<List<PersonFromJson>>(JSON);

                //Saving a file PersonsFromBanner.json on Folder c:\PersonsFromBanner
                File.WriteAllText(@"c:\PersonsFromBanner\PersonsFromBanner.json", JSON);
                Console.WriteLine("{0} extracted person(s) from Banner", personsFromBanner.Count + "\n");
                Console.WriteLine("-----------------------------------------------------------------------\n");

                foreach (var person in personsFromBanner)
                {
                    string output = JsonConvert.SerializeObject(person);
                    File.WriteAllText(@"c:\PersonsFromBanner\" + person.Id +".json", output);
                    
                    Console.WriteLine("Sync and extracting persons from Banner {0} ", output + "\n");
                    Console.WriteLine("-----------------------------------------------------------------\n");
                }
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
   
        }
    }
}
