Feature: Try vscode
    As a tester
    I want to run some gherkin tests in vscode
    So that I know that specflow works in vscode


Scenario: A gherkin test runs in vscode
    Given a gherkin test
    When the test is run in vscode
    Then the test result is pass


Scenario: Another gherkin test
    Given a gherkin test
    When the test is run in vscode
    Then the test result is fail


Scenario: Yet another one
    Given a gherkin test
    When the test is run in vscode
    Then the test result is pass