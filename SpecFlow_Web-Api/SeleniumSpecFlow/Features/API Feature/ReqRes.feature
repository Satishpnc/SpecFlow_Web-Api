@api
Feature: List pull requests

    @Api_GitHub
	Scenario Outline: Get list of pull requests which has more than count 1
	Given I create request body for endpoint
	When I requested "GET" for <Owner> and <Repo> to list pull requests
	Then I should see the status of pull request list <Status>
	And I should see the <ResponseCode>
	Examples:
	| Owner                   | Repo                      | ResponseCode | Status   |
	| sympli-coding-challenge | QA-CC-V1-OperaHouse       | 200          | OK       |
	| sympli-coding-challenge | QA-CC-V1-GreatBarrierReef | 200          | OK       |
	| sympli-coding-challenge | NoSuchRepo                | 404          | NotFound |