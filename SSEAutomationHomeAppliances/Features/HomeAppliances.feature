Feature: HomeAppliances feature file
	
Background: 
	Given I am on citizen advice home page
	  |Url                                                                                                                                               |BrowserName |
	  |https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/ |Chrome      |

@Sceanrios
Scenario: Home Appliances For England
	Given I am on Compare how much electrical appliances cost to use screen
	When I select country as "England"
    And I enter the below list of appliances and click on Add appliance to your list
    	|Appliance  |Hours |Minutes |KWH |
    	|Air friyer | 1    |10      |34  |
        |Broadband router | 0    |30      |	 |
        |Dehumidifier | 1    |30      |    |
        |Dishwasher 		| 1    |00      |    |
        |DVD or Blu-ray Player| 1    |30      |    |
        |Electric blanket     | 2    |10      |    |
        |Electric car charger (wall box)| 1  |10  |    |
        |Extractor fan 	| 1    |10      |    |
    Then all the "8" appliances list should be displayed in the table below.
        
	Scenario: Home Appliances For Scotland
		Given I am on Compare how much electrical appliances cost to use screen
		When I select country as "Scotland"
		And I enter the below list of appliances and click on Add appliance to your list
		  | Appliance                        | Hours | Minutes | KWH |
		  | Air friyer                       | 1     | 10      | 67  |
		  | Broadband router                 | 0     | 30      |     |
		  | Dehumidifier                     | 1     | 30      |     |
		  | Dishwasher                       | 1     | 00      |     |
		  | DVD or Blu-ray Player            | 1     | 30      |     |
		  | Electric blanket                 | 2     | 10      |     |
		  | Electric car charger (wall box)  | 1     | 10      |     |
		  | Extractor fan                    | 1     | 10      |     |
		  | Fan heater                       | 0     | 15      |     |
		  | Games console                    | 0     | 30      |     |
		Then all the "10" appliances list should be displayed in the table below.

	Scenario: Home Appliances For Wales
		Given I am on Compare how much electrical appliances cost to use screen
		When I select country as "Wales"
		And I enter the below list of appliances and click on Add appliance to your list
		  | Appliance                        | Hours | Minutes | KWH |
		  | Air friyer                       | 1     | 10      | 67  |
		  | Broadband router                 | 0     | 30      |     |
		  | Dehumidifier                     | 1     | 30      |     |
		  | Dishwasher                       | 1     | 00      |     |
		  | DVD or Blu-ray Player            | 1     | 30      |     |
		Then all the "5" appliances list should be displayed in the table below.

	Scenario: Home Appliances For Northern Ireland
		Given I am on Compare how much electrical appliances cost to use screen
		When I select country as "Northern Ireland"
		Then I should be displayed with message "The advice on this website doesn't cover Northern Ireland"