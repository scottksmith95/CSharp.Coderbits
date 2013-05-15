using System;
using System.Collections.Generic;

namespace CSharp.Coderbits
{
    public class CoderbitsModel
    {
        public string name { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string website_link { get; set; }
        public string bio { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public int views { get; set; }
        public string username { get; set; }
        public string link { get; set; }
        public string gravatar_hash { get; set; }
        public int one_bit_badges { get; set; }
        public int eight_bit_badges { get; set; }
        public int sixteen_bit_badges { get; set; }
        public int thirty_two_bit_badges { get; set; }
        public int sixty_four_bit_badges { get; set; }
        public int follower_count { get; set; }
        public int following_count { get; set; }
        public List<Stat> top_skills { get; set; }
        public List<Stat> top_languages { get; set; }
        public List<Stat> top_environments { get; set; }
        public List<Stat> top_frameworks { get; set; }
        public List<Stat> top_tools { get; set; }
        public List<Stat> top_interests { get; set; }
        public List<Stat> top_traits { get; set; }
        public List<Stat> top_areas { get; set; }
        public List<Badge> badges { get; set; }

        public class Stat
        {
            public string name { get; set; }
            public int count { get; set; }
        }

        public class Badge
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string link { get; set; }
            public string image_link { get; set; }
            public bool earned { get; set; }
            public string earned_date { get; set; }
            public int current_value { get; set; }
            public int needed_value { get; set; }
            public int level { get; set; }
            public string trait { get; set; }
            public string trait_description { get; set; }
        }
    }
}
