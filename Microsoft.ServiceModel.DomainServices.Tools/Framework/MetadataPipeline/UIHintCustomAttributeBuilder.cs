﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.ServiceModel.DomainServices.Tools
{
    /// <summary>
    /// Class to generate code for the [UIHint] attribute.
    /// </summary>
    /// <remarks>
    /// Specialization is required for the non-standard way this attribute allows a variable number
    /// of parameters and composes them into a dictionary of name value pairs.
    /// </remarks>
    internal class UIHintCustomAttributeBuilder : StandardCustomAttributeBuilder
    {
        public override AttributeDeclaration GetAttributeDeclaration(Attribute attribute)
        {
            UIHintAttribute uiHintAttribute = (UIHintAttribute)attribute;

            // We override this build method only to deal with the control parameters
            // which cannot be generated by the standard builder.  If there are no
            // control parameters, let the standard builder do the work.
            IDictionary<string, object> controlParams = uiHintAttribute.ControlParameters;
            if (controlParams == null || controlParams.Count == 0)
            {
                return base.GetAttributeDeclaration(attribute);
            }

            AttributeDeclaration attributeDeclaration = new AttributeDeclaration(typeof(UIHintAttribute));

            // UIHint[("uiHint", "presentationLayer")]
            attributeDeclaration.ConstructorArguments.Add(uiHintAttribute.UIHint);
            attributeDeclaration.ConstructorArguments.Add(uiHintAttribute.PresentationLayer);

            // UIHint[("uiHint", "presentationLayer", ...)] -- fill in all the optional params from control parameters
            foreach (KeyValuePair<string, object> item in controlParams)
            {
                attributeDeclaration.ConstructorArguments.Add(item.Key);
                attributeDeclaration.ConstructorArguments.Add(item.Value);
            }

            return attributeDeclaration;
        }
    }
}
