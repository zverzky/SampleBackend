﻿namespace SampleBackend.Models.Responses
{
    public class UserWithOrdersResponse : UserResponse
    {
        public bool RememberMe { get; set; }
        public DateTime BirthDate { get; set; }
        
    }
}
