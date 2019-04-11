Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

@mytag
Scenario: Check if user is able to edit a Lanuage level
  Given I clicked on the dropdown tab under Profile page
	When I upadte a laguage level
	Then that should be displayed on my listings

@mytag
	Scenario: Check if user is able to add multiple Lanuages
    Given I clicked on the language under Profile page
	When I add another new laguage
	Then that language should be displayed on my listings

@mytag
	Scenario: Check if user could able to add a skill 
	Given I clicked on the skill tab under Profile page
	When I add a skill
	Then that skill should be displayed on my listings

@mytag
	Scenario: Check if user could able add multiple skills
	Given I clicked on the skill tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

@mytag
	Scenario: Check if user could edit a skill
	Given I clicked on the skill tab under Profile page
	When I change a skill level
	Then that updated level should be displayed on my listings

@mytag
	Scenario: Check if user could able to add Education
	 Given I clicked on the Education tab under Profile page
	 When I add Education
	 Then all the options should be displayed under education tab
@mytag
	Scenario:Check if user is able to add university or college
	Given I clicked on the Educaton tab under profile page
	When I add University or college
	Then that particular university or college should be displayed

@mytag
	Scenario: Check if user is able to edit country of unviersity or college
	Given I clicked onthe dropdown menu of country of university or college
	When I add the country of University or college
	Then It should display all the listed countries





