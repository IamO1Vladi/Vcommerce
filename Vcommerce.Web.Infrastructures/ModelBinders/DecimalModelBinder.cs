﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace Vcommerce.Web.Infrastructures.ModelBinders
{
    public class DecimalModelBinder: IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext? bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueResult != ValueProviderResult.None && !string.IsNullOrWhiteSpace(valueResult.FirstValue))
            {
                decimal parsedValue = 0m;
                bool binderSucceeded = false;

                try
                {
                    string formDecimalValue=valueResult.FirstValue;

                    formDecimalValue = formDecimalValue.Replace(",",
                        CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    formDecimalValue = formDecimalValue.Replace(".",
                        CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    parsedValue= Convert.ToDecimal(formDecimalValue);

                    binderSucceeded = true;
                }
                catch (Exception formatException)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName,formatException,bindingContext.ModelMetadata);
                }

                if (binderSucceeded)
                {
                    bindingContext.Result=ModelBindingResult.Success(parsedValue);
                }

            }

            return Task.CompletedTask;
        }
    }
}
