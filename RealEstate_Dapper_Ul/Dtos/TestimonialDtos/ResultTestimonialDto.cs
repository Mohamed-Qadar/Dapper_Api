﻿namespace RealEstate_Dapper_Ul.Dtos.TestimonialDtos

{
    public class ResultTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string NameSurnam { get; set; }
        public string Title {  get; set; }
        public string Comment { get; set; }
        public bool Status { get; set;}
    }
}