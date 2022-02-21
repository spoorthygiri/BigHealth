Feature: Login

A Group of Test cases to validate signin process to get score details

@SleepScoreSigninTests
Scenario: Users were able to Signin with exisiting credentials to view sleepin score
	Given Users were able to enter the url in the browser
	When Users Clicks on the Login Button
	Then Enter exisitng user email address
	Then Enter exisiting password
	Then Click on Login button
	Then validate Content in the sleepio main screen
	Then validate logout button

@SleepScoreSigninTests
Scenario: Users were able to see error message when enters wrong password
	When Users Clicks on the Login Button
	Then Enter exisitng user email address
	Then Enter wrong  password
	Then Click on Login button
	Then validate error message in login screen

@SleepScoreSigninTests
Scenario: Users were able to see error message when enters non exisiting email
	When Users Clicks on the Login Button
	Then Enter exisitng user non exisiting email address
	Then Enter exisiting password
	Then Click on Login button
	Then validate error message in login screen


	#We can add one more test for forgot password 