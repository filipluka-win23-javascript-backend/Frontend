﻿using System.ComponentModel.DataAnnotations;

namespace Frontend.Filters;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
}

