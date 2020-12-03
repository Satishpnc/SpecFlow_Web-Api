@web
Feature: Validate Pull Requests Functionality

Background:
	Given I navigate to sympli-coding-challenge GitHub

	@Web_GitHub
	Scenario Outline: Validate there should be different source and target branch(s) while raising PR
	Given I navigate to <repo> to raise PR
	When I raise new pull request of <source_branch> and <target_branch>
	Then I should able to see the <message>
	Examples:
	| repo                  | source_branch | target_branch              | message                                                                  |
	| QA-CC-V1-OperaHouse   | master        | develop                    | Able to merge                                                            |
	| QA-CC-V1-OperaHouse   | master        | master                     | You’ll need to use two different branch names to get a valid comparison. |
	| QA-CC-V1-Campbelltown | develop       | sympli-cc-qa-write-patch-1 | Can’t automatically merge.                                               |
	
	@Web_GitHub
	Scenario Outline:  Validate there should have different commits in source and target while raising PR
	Given I navigate to <repo> to raise PR
	When I raise new pull request of <source_branch> and <target_branch>
	Then I should able to see the <message>
	Examples:
	| repo                   | source_branch | target_branch | message                           |
	| QA-CC-V1-HarbourBridge | master        | develop       | master and develop are identical. |
	| QA-CC-V1-Kakadu        | main          | develop       | Able to merge                     |
	
	@Web_GitHub
	Scenario Outline: Validate duplicate PR prompts interactive message and user can able to see it with a click
	Given I navigate to <repo> to raise PR
	When I raise new pull request of <source_branch> and <target_branch>
	Then I should able to see the <message>
	And I should see the pull request raised by clicking 'View pull request' button
	Examples:
	| repo                  | source_branch | target_branch | message        |
	| QA-CC-V1-Campbelltown | master        | develop       | Able to merge. |
	
	@Web_GitHub
	Scenario Outline: Validate PR can't be raised for empty repo
	Given I navigate to <repo> to raise PR
	When I raise new pull request of <source_branch> and <target_branch>
	Then I should able to see the <message>
	Examples:
	| repo                | source_branch | target_branch | message                          |
	| QA-CC-V1-OperaHouse | master        | develop       | Able to merge                    |
	| QA-CC-V1-OperaHouse | master        | master        | You’ll need to use two different branch names to get a valid comparison. |

