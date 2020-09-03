﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I request an event authorization")]
        public void RequestEventAuthorization()
        {
            /* 
            Page Title: Licences
            Subtitle:   Catering Licences
            */

            string requestEventAuthorization = "Request Event Authorization";

            // click on the request event authorization link
            NgWebElement uiRequestEventAuthorization = ngDriver.FindElement(By.LinkText(requestEventAuthorization));
            uiRequestEventAuthorization.Click();

            /* 
            Page Title: Catered Event Authorization Request
            */

            // create event authorization data
            string eventContactName = "AutoTestEventContactName";
            string eventContactPhone = "2500000000";

            string eventDescription = "Automated test event description added here.";
            string eventClientOrHostName = "Automated test event";
            string maximumAttendance = "100";
            string maximumStaffAttendance = "25";

            string venueNameDescription = "Automated test venue name or description";
            string venueAdditionalInfo = "Automated test additional venue information added here.";
            string physicalAddStreetAddress1 = "Automated test street address 1";
            string physicalAddStreetAddress2 = "Automated test street address 2";
            string physicalAddCity = "Victoria";
            string physicalAddPostalCode = "V9A 6X5";

            // enter event contact name
            NgWebElement uiEventContactName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactName']"));
            uiEventContactName.SendKeys(eventContactName);

            // enter event contact phone
            NgWebElement uiEventContactPhone = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPhone']"));
            uiEventContactPhone.SendKeys(eventContactPhone);

            // select event type
            NgWebElement uiEventType = ngDriver.FindElement(By.CssSelector("[formcontrolname='eventType'] option[value='2: 845280002']"));
            uiEventType.Click();

            // enter event description
            NgWebElement uiEventDescription = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='eventTypeDescription']"));
            uiEventDescription.SendKeys(eventDescription);

            // enter event client or host name
            NgWebElement uiEventClientOrHostName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='clientHostname']"));
            uiEventClientOrHostName.SendKeys(eventClientOrHostName);

            // enter maximum attendance
            NgWebElement uiMaxAttendance = ngDriver.FindElement(By.CssSelector("input[formcontrolname='maxAttendance']"));
            uiMaxAttendance.SendKeys(maximumAttendance);

            // enter maximum staff attendance
            NgWebElement uiMaxStaffAttendance = ngDriver.FindElement(By.CssSelector("input[formcontrolname='maxStaffAttendance']"));
            uiMaxStaffAttendance.SendKeys(maximumStaffAttendance);

            // select whether minors are attending - yes
            NgWebElement uiMinorsAttending = ngDriver.FindElement(By.CssSelector("[formcontrolname='minorsAttending'] option[value='true']"));
            uiMinorsAttending.Click();

            // select type of food service provided
            NgWebElement uiFoodServiceProvided = ngDriver.FindElement(By.CssSelector("[formcontrolname='foodService'] option[value='0: 845280000']"));
            uiFoodServiceProvided.Click();

            // select type of entertainment provided
            NgWebElement uiEntertainmentProvided = ngDriver.FindElement(By.CssSelector("[formcontrolname='entertainment'] option[value='1: 845280001']"));
            uiEntertainmentProvided.Click();

            // enter venue name description
            NgWebElement uiVenueNameDescription = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='venueDescription']"));
            uiVenueNameDescription.SendKeys(venueNameDescription);

            // select venue location
            NgWebElement uiVenueLocation = ngDriver.FindElement(By.CssSelector("[formcontrolname='specificLocation'] option[value='2: 845280002']"));
            uiVenueLocation.Click();

            // enter venue additional info
            NgWebElement uiVenueAdditionalInfo = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='additionalLocationInformation']"));
            uiVenueAdditionalInfo.SendKeys(venueAdditionalInfo);

            // enter physical address - street address 1
            NgWebElement uiPhysicalAddStreetAddress1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='street1']"));
            uiPhysicalAddStreetAddress1.SendKeys(physicalAddStreetAddress1);

            // enter physical address - street address 2 
            NgWebElement uiPhysicalAddStreetAddress2 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='street2']"));
            uiPhysicalAddStreetAddress2.SendKeys(physicalAddStreetAddress2);

            // enter physical address - city
            NgWebElement uiPhysicalAddCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname='city']"));
            uiPhysicalAddCity.SendKeys(physicalAddCity);

            // enter physical address - postal code
            NgWebElement uiPhysicalAddPostalCode = ngDriver.FindElement(By.CssSelector("input[formcontrolname='postalCode']"));
            uiPhysicalAddPostalCode.SendKeys(physicalAddPostalCode);

            // select start date
            NgWebElement uiVenueStartDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='startDate']"));
            uiVenueStartDate1.Click();

            NgWebElement uiVenueStartDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
            uiVenueStartDate2.Click();

            // select end date
            NgWebElement uiVenueEndDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='endDate']"));
            uiVenueEndDate1.Click();

            NgWebElement uiVenueEndDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
            uiVenueEndDate2.Click();

            // select event and liquor service times are different on specific dates checkbox
            NgWebElement uiEventLiquorServiceTimesDifferent = ngDriver.FindElement(By.Id("mat-checkbox-1"));
            uiEventLiquorServiceTimesDifferent.Click();

            // select terms and conditions checkbox
            NgWebElement uiTermsAndConditions = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='agreement']"));
            uiTermsAndConditions.Click();

            /* 
            Page Title: Licences
            Subtitle:   Catering Licences
            */

            // click on the Event History bar - TODO
            // NgWebElement expandEventHistory = ngDriver.FindElement(By.Id("mat-expansion-panel-header-1"));
            // expandEventHistory.Click();

            // confirm that the Event Status = In Review and the Client or Host Name is present - TODO
            // Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,eventContactName)]")).Displayed);
        }

        [And(@"I do not complete the event authorization application correctly")]
        public void EventAuthorizationValidation()
        {
            // remove event contact name
            NgWebElement uiEventContactName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactName']"));
            uiEventContactName.Clear();

            // remove event contact phone
            NgWebElement uiEventContactPhone = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPhone']"));
            uiEventContactPhone.Clear();

            // remove event description
            NgWebElement uiEventDescription = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='eventTypeDescription']"));
            uiEventDescription.Clear();

            // remove event client or host name
            NgWebElement uiEventClientOrHostName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='clientHostname']"));
            uiEventClientOrHostName.Clear();

            // remove maximum attendance
            NgWebElement uiMaxAttendance = ngDriver.FindElement(By.CssSelector("input[formcontrolname='maxAttendance']"));
            uiMaxAttendance.Clear();

            // remove maximum staff attendance
            NgWebElement uiMaxStaffAttendance = ngDriver.FindElement(By.CssSelector("input[formcontrolname='maxStaffAttendance']"));
            uiMaxStaffAttendance.Clear();

            // remove venue name description
            NgWebElement uiVenueNameDescription = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='venueDescription']"));
            uiVenueNameDescription.Clear();

            // remove venue additional info
            NgWebElement uiVenueAdditionalInfo = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='additionalLocationInformation']"));
            uiVenueAdditionalInfo.Clear();

            // remove physical address - street address 1
            NgWebElement uiPhysicalAddStreetAddress1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='street1']"));
            uiPhysicalAddStreetAddress1.Clear();

            // remove physical address - street address 2 
            NgWebElement uiPhysicalAddStreetAddress2 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='street2']"));
            uiPhysicalAddStreetAddress2.Clear();

            // remove physical address - city
            NgWebElement uiPhysicalAddCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname='city']"));
            uiPhysicalAddCity.Clear();

            // remove physical address - postal code
            NgWebElement uiPhysicalAddPostalCode = ngDriver.FindElement(By.CssSelector("input[formcontrolname='postalCode']"));
            uiPhysicalAddPostalCode.Clear();

            // deselect event and liquor service times are different on specific dates checkbox
            NgWebElement uiEventLiquorServiceTimesDifferent = ngDriver.FindElement(By.Id("mat-checkbox-1"));
            uiEventLiquorServiceTimesDifferent.Click();

            // deselect terms and conditions checkbox
            NgWebElement uiTermsAndConditions = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='agreement']"));
            uiTermsAndConditions.Click();
        }
    }
}