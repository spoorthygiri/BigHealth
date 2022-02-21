Feature: SleepScoreSignup

A Group of Test cases to validate signup process to get score details

@SleepScoreSignupTests
Scenario: Users were able to successfully land to home page after clicking URl
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to see login and getstarted buttons
	Then Validate Content on the Home Page

@SleepScoreSignupTests
Scenario: Users were able to Select Details to signup to get sleep score
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to Click on Get started Button
	Then validate Content in the '2' screen
	Then Select '1' rd/th option in  Screen
	Then Select on Continue Button
	Then validate Content in the '3' screen
	Then Select Dropdown in the the screen
	#--Just like screen 2 we can validate the data in dropdown ,skipping for reducing the complexity
	Then Select '5' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '4' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then validate Content in the '5' screen
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '6' screen
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '7' screen
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '8' screen
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '9' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select 'month' Dropdown in the the screen
	Then Select 'month' rd/th option in  Screen from drop down for DOB
	Then Select 'day' Dropdown in the the screen
	Then Select 'day' rd/th option in  Screen from drop down for DOB
	Then Select 'year' Dropdown in the the screen
	Then Select 'year' rd/th option in  Screen from drop down for DOB
	Then Select on Continue Button
	Then validate Content in the '11' screen
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '12' screen
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then validate Content in the '13' screen
	Then Select textbox in the screen and enter value '45'
	Then Select on Continue Button
	Then validate Content in the '14' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Field enter value for first name 'Spoorthy'
	Then Select Field enter value for last name 'Giri'
	Then Select Field enter value for email 
	Then Select Field enter value for password 'Test@1234'
	Then Agree to terms and conditions
	Then Acknowledge to certain things
	Then Select on Continue Button
	Then validate Content in the sleepio main screen
	Then validate logout button


	@SleepScoreSignupTests
Scenario: Users were able to See error when enters wrong working hours
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to Click on Get started Button
	Then Select '1' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	#--Just like screen 2 we can validate the data in dropdown ,skipping for reducing the complexity
	Then Select '5' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select 'month' Dropdown in the the screen
	Then Select 'month' rd/th option in  Screen from drop down for DOB
	Then Select 'day' Dropdown in the the screen
	Then Select 'day' rd/th option in  Screen from drop down for DOB
	Then Select 'year' Dropdown in the the screen
	Then Select 'year' rd/th option in  Screen from drop down for DOB
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select textbox in the screen and enter value '55'
	Then user should see Error message to enter value in right range


@SleepScoreSignupTests
Scenario: Users were able to See error when enters email address in wromg format
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to Click on Get started Button
	Then Select '1' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	#--Just like screen 2 we can validate the data in dropdown ,skipping for reducing the complexity
	Then Select '5' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select 'month' Dropdown in the the screen
	Then Select 'month' rd/th option in  Screen from drop down for DOB
	Then Select 'day' Dropdown in the the screen
	Then Select 'day' rd/th option in  Screen from drop down for DOB
	Then Select 'year' Dropdown in the the screen
	Then Select 'year' rd/th option in  Screen from drop down for DOB
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select textbox in the screen and enter value '45'
	Then Select on Continue Button
	Then validate Content in the '14' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Field enter value for first name 'Spoorthy'
	Then Select Field enter value for last name 'Giri'
	Then Select Field enter value for incorrect email address format
	Then Select Field enter value for password 'Test@1234'
	Then Agree to terms and conditions
	Then Acknowledge to certain things
	Then Select on Continue Button
	Then User should see Error message related to email


@SleepScoreSignupTests
Scenario: Users were able to See error when enters password in wromg format
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to Click on Get started Button
	Then Select '1' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	#--Just like screen 2 we can validate the data in dropdown ,skipping for reducing the complexity
	Then Select '5' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select 'month' Dropdown in the the screen
	Then Select 'month' rd/th option in  Screen from drop down for DOB
	Then Select 'day' Dropdown in the the screen
	Then Select 'day' rd/th option in  Screen from drop down for DOB
	Then Select 'year' Dropdown in the the screen
	Then Select 'year' rd/th option in  Screen from drop down for DOB
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select textbox in the screen and enter value '45'
	Then Select on Continue Button
	Then validate Content in the '14' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Field enter value for first name 'Spoorthy'
	Then Select Field enter value for last name 'Giri'
	Then Select Field enter value for email 
	Then Select Field enter value for password 'test1234'
	Then Agree to terms and conditions
	Then Acknowledge to certain things
	Then Select on Continue Button
	Then User should see Error message related to password


@SleepScoreSignupTests
Scenario: Users were able to See error when user tries to register with same email address
	Given Users were able to enter the url in the browser
	When System loads the home page
	Then validate users were able to Click on Get started Button
	Then Select '1' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	#--Just like screen 2 we can validate the data in dropdown ,skipping for reducing the complexity
	Then Select '5' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '2' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select 'month' Dropdown in the the screen
	Then Select 'month' rd/th option in  Screen from drop down for DOB
	Then Select 'day' Dropdown in the the screen
	Then Select 'day' rd/th option in  Screen from drop down for DOB
	Then Select 'year' Dropdown in the the screen
	Then Select 'year' rd/th option in  Screen from drop down for DOB
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '1' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select Dropdown in the the screen
	Then Select '3' rd/th option in  Screen from drop down
	Then Select on Continue Button
	Then Select textbox in the screen and enter value '45'
	Then Select on Continue Button
	Then validate Content in the '14' screen
	Then Select '2' rd/th option in  Screen
	Then Select on Continue Button
	Then Select Field enter value for first name 'Spoorthy'
	Then Select Field enter value for last name 'Giri'
	Then Select Field enter value for email with exisiting email address 
	Then Select Field enter value for password 'Test@1234'
	Then Agree to terms and conditions
	Then Acknowledge to certain things
	Then Select on Continue Button
	Then User should see Error message related to exiting email







