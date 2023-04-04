Feature: Profilefeature

As a Seller I want the feature to add my Profile Details
So that The people seeking for some skills can look into my details.

@tag1
Scenario: Want to add skills to my profile
   Given I logged into mars portal successfully
   When I navigated to the skill page
   And I added skill to my Profile
   Then The skill should be added successfully

Scenario: Want to add education to my profile
   Given I logged into mars portal successfully
   When I navigated to the education page
   And I added education to my Profile
   Then The education should be added successfully

Scenario: Want to add certification to my profile
   Given I logged into mars portal successfully
   When I navigated to the certification page
   And I added certification to my Profile
   Then The certification should be added successfully


   
