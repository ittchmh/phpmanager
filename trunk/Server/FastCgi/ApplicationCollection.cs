//------------------------------------------------------------------------------
// <copyright file="ApplicationCollection.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Microsoft.Web.Administration;

namespace Web.Management.PHP.FastCgi
{

    internal class FastCgiApplicationCollection : ConfigurationElementCollectionBase<ApplicationElement>
    {

        protected override ApplicationElement CreateNewElement(string elementTagName)
        {
            return new ApplicationElement();
        }

        public ApplicationElement GetApplication(string fullPath, string arguments)
        {
            for (int i = 0; i < Count; i++)
            {
                ApplicationElement element = base[i];
                if (String.Equals(fullPath, element.FullPath, StringComparison.OrdinalIgnoreCase) &&
                    String.Equals(arguments, element.Arguments, StringComparison.OrdinalIgnoreCase))
                {
                    return element;
                }
            }
            return null;
        }

    }
}