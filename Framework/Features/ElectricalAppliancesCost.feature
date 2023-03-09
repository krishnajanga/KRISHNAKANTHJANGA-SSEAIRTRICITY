Feature: ElelctricalAppliancescost
	Test script to know estimate of how much electrical appliances cost to run

@mytag
Scenario: Resident from England
	Given I am resident from England
		|Url								 |BrowserName|
		|https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/|Chrome	 |
	When I add the list appliances (add at least 8 appliances) and its average usage and the national average rate (34 kWh)
	Then I should get the results table with daily, weekly, monthly, and yearly cost.
	
Scenario: Resident from Scotland
	Given I am resident from Scotland
		|Url								 |BrowserName|
		|https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/|Chrome	 |
	When I add the list appliances (add at least 10 appliances) and its average usage and the national average rate (67 kWh)
	Then I should get the results table with daily, weekly, monthly, and yearly cost.
	
Scenario: Resident from Wales
	Given I am resident from Wales
		|Url								 |BrowserName|
		|https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/|Chrome	 |
	When I add the list appliances (add at least 5 appliances) and its average usage and the national average rate (67 kWh)
	Then I should get the results table with daily, weekly, monthly, and yearly cost.

Scenario: Resident from Northern Island
	Given I am resident from Northern Island
		|Url								 |BrowserName|
		|https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/|Chrome	 |
	When I select This advice applies to Northern Ireland
	Then I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’

