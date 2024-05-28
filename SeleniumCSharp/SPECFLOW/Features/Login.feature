Feature: Login Feature

  Scenario: Saucedemo Login Authentication
    Given I navigate to the login page
    When I enter valid credentials
    Then I should be logged in
