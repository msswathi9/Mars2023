Feature: Profilefeature

As a Seller I want the feature to add my Profile Details
So that The people seeking for some skills can look into my details.

@tag1
Scenario: Want to add skills to my profile
   Given I logged into mars portal successfully
   When I added skill to my Profile
   Then The skill should be added successfully

Scenario: Want to add education to my profile
   Given I logged into mars portal successfully
   When I added education to my Profile
   Then The education should be added successfully

Scenario: Want to add certification to my profile
   Given I logged into mars portal successfully
   When I added certification to my Profile
   Then The certification should be added successfully

Scenario: Want to add description to my profile
  Given I logged into mars portal successfully
  When I added description to my profile
  Then The description should added successfully

Scenario: Want to add add my details to Share skills page
  Given I logged into mars portal successfully
  When I added my setails to share skill page
  Then The share skill should be added successfully







   
