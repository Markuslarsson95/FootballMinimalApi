﻿namespace WebApp.DTOs.Stadium
{
    public record StadiumResponseDto(string Name,
        string Location,
        int Capacity,
        int YearBuilt,
        string Adress,
        string Club
        );
}
