Feature: Profilefeature

As a Seller I want the feature to add my Profile Details
So that The people seeking for some skills can look into my details.

@tag1
#Scenario: Want to add skills to my profile
   #Given I logged into mars portal successfully
   #When I added skill to my Profile
   #Then The skill should be added successfully

Scenario:1) Want to add education to my profile
   Given I logged into mars portal successfully
   When I added education to my Profile
   Then The education should be added successfully

Scenario Outline: 2) Want to update existing education record
  Given I logged into mars portal successfully
  When I Want to update existing Education record
  Then The record should be updated succesully
    

Scenario Outline:3) Want to delete education record
  Given  I logged into mars portal successfully
  When I Want to delte existing Education record
  Then The record should be deleted succesully


#Scenario: Want to add certification to my profile
  # Given I logged into mars portal successfully
  # When I added certification to my Profile
   #Then The certification should be added successfully

#Scenario: Want to add description to my profile
 # Given I logged into mars portal successfully
  #When I added description to my profile
  #Then The description should added successfully









   
