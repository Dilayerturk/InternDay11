using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQExample
{
    public class Repository : IRepository
    {

        public List<Band> GetBands()
        {
            //this would communicate with database to return data. 
            var ListofBands = new List<Band>();
            ListofBands.Add(
                new Band
                {
                    Name = "Uzay",
                    Origin = "İzmir",
                    Genre = "Rock",
                    BestSong = "Sabır"
                });

            ListofBands.Add(
                new Band
                {
                    Name = "Yat-Kha",
                    Origin = "Tuva Russia",
                    Genre = "Folk Rock",
                    BestSong = "Ahoi"
                });

            ListofBands.Add(
                new Band
                {
                    Name = "Peyk",
                    Origin = "İstanbul",
                    Genre = "Alternative",
                    BestSong = "İstanbul"
                });


            return ListofBands;
        }
    }
}