// ********************************************************************************************************************************************
// Copyright (c) 2019
// Author: USA
// Product: CHILI
// Version: 1.0.0
// ********************************************************************************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;
using Usa.chili.Dto;

namespace Usa.chili.Services
{
    /// <summary>
    /// Interface for VariableService.
    /// </summary>
    public interface IVariableService
    {
        Task<List<DropdownDto>> ListAllVariables();
        Task<List<VariableTypeDto>> ListAllVariableTypes();
    }
}