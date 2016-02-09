Feature: BookFlights
	In order to book a flight
	As a regular user
	I want to pay with credit card

Scenario Outline: Book a one way flight for adults and children
Given I am on RyanAir home page

	When I Select one way flight
	When I make a booking from <airportfrom> to <airportto> on <flightdate> for <nradults> adults and <nrchildren> children
	Then Choose flight page is displayed
	When I select flight number
	Then Extras page is displayed
	When I select extras
	Then Passengers page is displayed
	When I fill in passenger details with <passengername> and <passengersurname>
	And I pay for booking with details
	| <cardtype> | <cardnumber> | <cardvalid> |  <cvvcode> | <pas_name> | <pas_surname> | <pas_address> | <pas_city> | <pas_postalcode> | <pas_country> |
	Then I should get payment declined message


Examples:
| airportfrom | airportto | flightdate | nradults | nrchildren | cardtype | cardnumber       | cvvcode | cardvalid | pas_name | pas_surname | pas_title | pas_address | pas_city | pas_postalcode | pas_country | email | phonecountry | phonenumber |
| Dublin      | Berlin    | 11/03/2016 | 2        | 1          | VISA     | 5555555555555557 | 265     | 10/18     | Piotr    | Kula        | Mr        | Address     | Dublin   | 12345          | Ireland     | example_email@gmail.com | Poland       | 888888888   |


##########################################################################################

