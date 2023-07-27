﻿using Vcommerce.Data.Models.Enums;

namespace ClothingRepository.Interfaces;

public interface IClothingRepo
{

    public Task<Category[]> GetAvailableCategories(Gender gender);


}