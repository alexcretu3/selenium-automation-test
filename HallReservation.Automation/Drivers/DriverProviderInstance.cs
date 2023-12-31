﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallReservation.Automation.Drivers
{
    public class DriverProviderInstance
    {
        private IWebDriver _driver;
        public IWebDriver WebDriver
        {
            get
            {
                if (_driver == null)
                {
                    var timeout = 60;

                    var chromeOptions = new ChromeOptions();

                    chromeOptions.AddArgument("--window-size=1920,1080");
                    _driver = new ChromeDriver(chromeOptions);
                    _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);
                    _driver.Url = "https://localhost:7109";
                }

                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
    }
}
