Feature: HomeAppliancesCost
	Test script to know estimate of how much electrical appliances cost to run
Background: 
|Url								 |BrowserName|
|https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/|Chrome	 |
@tag
Scenario: Resident from England

	Given I am on Compare how much electrical appliances cost to use page
	When I Select the country as <countryname>
	And I completed the below details and click on Add appliance to your list button
	| Appliance        | Hours | Min | every | p/kwh
	| Air fryer        | 0     | 30  | week  | 34
	| Dishwasher       | 0     | 30  | day   | 
	| Broadband router | 24    | 0   | day   | 
	| Extractor fan    | 1     | 0   | day   | 
	| Hairdryer        | 0     | 45  | week  | 
	| Vacuum cleaner   | 1     | 30  | week  | 
	| Washing machine  | 3     | 0   | week  | 
	| Microwave        | 1     | 0   | week  | 
	Then I should get the results table with daily, weekly, monthly, and yearly cost.
	
Scenario: Resident from Scotland

	Given I am on Compare how much electrical appliances cost to use page
	When I Select the country as "Scotland"
	And I completed the below details and click on Add appliance to your list button
	| Appliance        | Hours | Min | every | p/kwh
	| Air fryer        | 0     | 30  | week  | 67
	| Dishwasher       | 0     | 30  | day   | 
	| Broadband router | 24    | 0   | day   | 
	| Extractor fan    | 1     | 0   | day   | 
	| Hairdryer        | 0     | 45  | week  | 
	| Vacuum cleaner   | 1     | 30  | week  | 
	| Washing machine  | 3     | 0   | week  | 
	| Microwave        | 1     | 0   | week  | 
	| Oven             | 2     | 0   | month |
	| Kettle           | 0     | 30  | daily |

	Then I should get the results table with daily, weekly, monthly, and yearly cost.
	
Scenario: Resident from Wales

	Given I am on Compare how much electrical appliances cost to use page
	When I Select the country as "Wales"
	And I completed the below details and click on Add appliance to your list button
	| Appliance        | Hours | Min | every | p/kwh
	| Air fryer        | 0     | 30  | week  | 67
	| Dishwasher       | 0     | 30  | day   | 
	| Broadband router | 24    | 0   | day   | 
	| Extractor fan    | 1     | 0   | day   | 
	| Hairdryer        | 0     | 45  | week  | 
	
	Then I should get the results table with daily, weekly, monthly, and yearly cost.

Scenario: Resident from Northern Ireland

	Given I am on Compare how much electrical appliances cost to use page
	When I Select the country as "Northern Ireland"
	Then I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’


