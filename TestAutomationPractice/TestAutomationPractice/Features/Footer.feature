Feature: Footer
    In order to use informatioon
	As a user
	I want to be able to work with footer links
	
@mytag
Scenario Outline: User can open links under Information section

When user clicks on '<informationlinks>' option
Then correct '<page>' is displayed
Examples:
|Information link                   |page|
|Specials                           |pricedrops|
|New products                       |New products|
|Best sellers                       |Best sellers|
|Our stores                         |Our store(s)!|
|Contact us                         |Contact|
|Terms and conditions of us         |Terms of conditions of use|
|About us                           |About us|
|Sitemap                            |Sitemap|
