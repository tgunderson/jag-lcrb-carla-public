﻿Feature: UBrewUVinLicenceApplication
    As a logged in business user
    I want to submit a UBrew / UVin Licence application for different business types

@ubrewuvinapplication @privatecorporation
Scenario: DEV UBrew / UVin Application (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a private corporation
    And I complete the UBrew / UVin application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinapplication @partnership 
Scenario: DEV UBrew / UVin Application (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a partnership
    And I complete the UBrew / UVin application for a partnership
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinapplication @publiccorporation 
Scenario: DEV UBrew / UVin Application (Public Corporation)
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a public corporation
    And I complete the UBrew / UVin application for a public corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinapplication @soleproprietorship 
Scenario: DEV UBrew / UVin Application (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a sole proprietorship
    And I complete the UBrew / UVin application for a sole proprietorship
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

#@ubrewuvinapplication @partnership 
#Scenario: UAT UBrew / UVin Application (Partnership)
#    Given I am logged in to the dashboard as a partnership
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a partnership
#    And I review the organization structure for a partnership
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a partnership
#    And I click on the Submit button
#    And I review the security screening requirements for a partnership
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page

#@ubrewuvinapplication @privatecorporation
#Scenario: UAT UBrew / UVin Application (Private Corporation)
#    Given I am logged in to the dashboard as a private corporation
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a private corporation
#    And I review the organization structure for a private corporation
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a private corporation
#    And I click on the Submit button
#    And I review the security screening requirements for a private corporation
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
#
#@ubrewuvinapplication @publiccorporation 
#Scenario: UAT UBrew / UVin Application (Public Corporation)
#    Given I am logged in to the dashboard as a public corporation
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a public corporation
#    And I review the organization structure for a public corporation
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a public corporation
#    And I click on the Submit button
#    And I review the security screening requirements for a public corporation
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
#
#@ubrewuvinapplication @soleproprietorship 
#Scenario: UAT UBrew / UVin Application (Sole Proprietorship)
#    Given I am logged in to the dashboard as a sole proprietorship
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a sole proprietorship
#    And I review the organization structure for a sole proprietorship
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a sole proprietorship
#    And I click on the Submit button
#    And I review the security screening requirements for a sole proprietorship
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page