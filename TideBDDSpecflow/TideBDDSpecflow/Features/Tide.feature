Feature: Tide.Com Web Application 

for users to search products, shop products

@Language
Scenario: 
	Given Load the website 
	And user click on language
	When user select language 
	Then websites language changed

@Shop
Scenario:
     Given Lunch the tide website
	 And hover mouse pointer on the shop product
	 When click on pacs  product  
	 Then result for pacs product displayed

@Commitment
 Scenario:
 Given Open browser and open Website
 And hover mouse pointer on the our commitment
 When click on our ambition 
 Then our ambtion displayed

 @Wash
 Scenario: 
 Given Open  The Website
 And  hover mouse pointer on the how to wash clothes 
 When click on how to remove stains 
 Then Information for How to remove stain dispalyed

 @Coupns
 Scenario:  
 Given open the web
 And click on Coupons and rewards
 When click on save now 
 Then page redirected on log in page

 @livechat
 Scenario: 
 Given Open  the Tide Website
 When Click on Live Chat
 Then Page redirected on Live chat page

 @Change
 Scenario:  
 Given Open the Tidecom website 
 And click on website language 
 When user select the language
 Then language shown in the selected language

 @changelanguage
  Scenario:
 Given load the tidecom website
 And Enter the product name in the search box 
 When click on the search icon 
 Then result for Searched product displayed 



