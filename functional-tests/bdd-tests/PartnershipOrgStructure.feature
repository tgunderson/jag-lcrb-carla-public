﻿Feature: PartnershipOrgStructure.feature
    As a logged in partnership business user
    I want to confirm the organization structure functionality

@e2e @cannabis @partnership @validation @orgstructure
Scenario: Change director name and pay fee - partnership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee for Cannabis
    And I return to the dashboard
    And I click on the Dashboard link
    And I click on the Review Organization Information button
    And I modify only the individual partner record
    And I click on the Submit Organization Information button
    And I pay the name change fee
    And the individual shareholder name is now updated
    And the account is deleted
    Then I see the login page

@cannabis @partnership @validation @orgstructure
Scenario: Delete an individual who is both a director and shareholder - partnership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Complete Organization Information button
    And I enter the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I delete only the individual partner record
    And I click on the Complete Organization Information button
    And only the business shareholder record is displayed
    And the account is deleted
    Then I see the login page

@cannabis @partnership @validation @orgstructure
Scenario: Change director and shareholder same name - partnership
    # under development
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Complete Organization Information button
    And I enter the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I modify only the individual partner record
    And I click on the Complete Organization Information button
    And the individual partner and business shareholder name are identical
    And the account is deleted
    Then I see the login page

@cannabis @partnership @validation @orgstructure
Scenario: Confirm business shareholder org structure update - partnership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Complete Organization Information button
    And I enter the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I add a business shareholder with the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I add a second individual as an individual partner and a business shareholder 
    And I click on the Confirm Organization Information is Complete button
    And I click on the Complete Organization Information button
    And the partnership org structure is correct
    And I remove the latest individual partner and business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And the latest individual partner and business shareholder is removed
    And I remove the business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And the business shareholder is removed
    And the account is deleted
    Then I see the login page

@cannabis @partnership @validation @orgstructure
Scenario: Confirm business shareholder org structure update after payment - partnership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Complete Organization Information button
    And I enter the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I add a business shareholder with the same individual as an individual partner and a business shareholder
    And I click on the Submit Organization Information button
    And I click on the Complete Organization Information button
    And I add a second individual as an individual partner and a business shareholder 
    And I click on the Confirm Organization Information is Complete button
    And I click on the Complete Organization Information button
    And the partnership org structure is correct
    And I click on the Confirm Organization Information is Complete button
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I click on the Confirm Organization Information is Complete button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Review Organization Information button
    And the partnership org structure is correct after payment
    And the account is deleted
    Then I see the login page

@cannabis @partnership @validation @orgstructure
Scenario: Save for Later feature for org structure - partnership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Complete Organization Information button
    And I enter the same individual as an individual partner and a business shareholder
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And I add a business shareholder with the same individual as an individual partner and a business shareholder
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And I add a second individual as an individual partner and a business shareholder
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And I remove the latest individual shareholder after saving
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And I remove the latest business shareholder after saving
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And the latest director and shareholder is removed
    And I remove the business shareholder
    And I click on the Save for Later button
    And I click on the Complete Organization Information button
    And the saved org structure for partnership is present
    And the account is deleted
    Then I see the login page