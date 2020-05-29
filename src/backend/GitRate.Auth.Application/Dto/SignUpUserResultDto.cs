﻿using System;

namespace Auth.Application.Dto
{
    public class SignUpUserResultDto
    {
        public SignUpUserResultDto(string jwtToken)
        {
            if (string.IsNullOrEmpty(jwtToken))
                throw new ArgumentException("Jwt token cannot be null or empty", nameof(jwtToken));
            
            JwtToken = jwtToken;
        }
        
        public string JwtToken { get; }
    }
}