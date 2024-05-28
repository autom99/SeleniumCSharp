Feature: Login Feature

  Scenario: Successful Login
    Given I navigate to the login page
    When I enter valid credentials
    Then I should be logged in
