using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfwLabRescue.Web.Models
{
    class ContentBuilder
    {
        internal ICollection<Content> Build()
        {
            var contentList = new List<Content>();
            contentList.Add(BuildVolunteerPage());
            contentList.Add(BuildFosterPage());
            contentList.Add(BuildDonationPage());
            contentList.Add(BuildApplicationTermsPage());
            contentList.AddRange(BuildMiscPages());

            return contentList;
        }

        private IEnumerable<Content> BuildMiscPages()
        {
            return new List<Content> {
                new Content {ContentId = "InMemoriam", Title = "In Memoriam", Breadcrumbs = true},
                new Content {ContentId = "SpecialNeeds", Title = "Amazing Dogs with Special Needs", Breadcrumbs = true},
                new Content {ContentId = "ThinkBeforeAdopting", Title= "Think Before Adopting", Breadcrumbs = true},
                new Content {ContentId = "Stories", Title = "Success Stories", Breadcrumbs = true},
                new Content {ContentId = "VetInfo", Title = "Veterinary Information", Breadcrumbs = true},
                new Content {ContentId = "FAQ", Title = "Frequently Asked Questions", Breadcrumbs = true},
                new Content {ContentId = "HelpfulLinks", Title = "Helpful Links", Breadcrumbs = true},
            };
        }

        private Content BuildVolunteerPage()
        {
            return new Content { 
                ContentId = "Volunteer",
                Title = "Volunteer",
                CssFile = "/assets/css/pages/page_one.css",
                Published = true,
                RawHtml = @"
    <!--=== Purchase Block ===-->
    <div class=""purchase"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 animated fadeInLeft"">
                    <span>We have some of the best volunteers around! Still, we struggle to meet the demands with all the Labs that end up in shelters each and every week. The numbers are truly staggering, and the work to be done is never ending. What can you do to help?</span>
					
                </div>            
                <div class=""col-md-4 btn-buy animated fadeInRight"">
                    <a href=""/Applications/Volunteer"" class=""btn-u btn-u-lg""><i class=""fa fa-cloud-download""></i> Apply to Volunteer Now</a>
                </div>
            </div>
        </div>
    </div><!--/row-->
    <!-- End Purchase Block -->

    <!--=== Content Part ===-->
    <div class=""one-page"">
        <div class=""one-page-inner one-default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Volunteers, they are the lifeline for each and every lab that comes through DFWLRRC. Just look into the eyes of any of the rescues and you will see their eternal gratitude for that second chance at life...the second chance our volunteers gave to them. They are so thankful a volunteer listened to that inner voice that nudged them into signing up to do that home study, showing up to that meet n greet to talk with potential adopters or opening up their home to foster that Lab in need. Yes, each and every one of our volunteers makes a difference -- no matter what the contribution. Without our volunteers we would not have been able to help nearly 500* Labs since 2004.</p>
<p>
We have some of the best volunteers around! Still, we struggle to meet the demands with all the Labs that end up in shelters each and every week. The numbers are truly staggering, and the work to be done is never ending. What can you do to help?</p>
<p>While fostering is our greatest need, it isn't for everyone. If you cannot foster, there are still so many ways you can help:</p>
                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/dogs/be_a_hero.jpeg"" class=""img-responsive margin-bottom-10"" alt="""">
                    </div>
                </div>
            </div>
        </div>


    </div><!--/one-page-->
    <div class=""container content"">
<div class=""row"">
    <div class=""col-md-6"">
    
        <!-- Bordered Funny Boxes -->
        <div class=""funny-boxes funny-boxes-left-orange"">
            <div class=""row"">
                <div class=""col-md-4 funny-boxes-img"">
                    <img class=""img-responsive"" src=""/assets/img/dogs/girlanddog.jpg"" alt="""">
                </div>
                <div class=""col-md-8"">
                    <h2><a href=""#"">Attend a Meet N Greet</a></h2>
                    <p>These are the events where our foster dogs meet potential adopters, a step towards finding their forever homes. We are always in need of volunteers to transport and hold fosters, set up and break down the booth, take the dogs on potty breaks, fill water bowls and talk to potential adopters. We typically hold one to two of these events on the weekends. Each event requires at least 3-5 dogs and 5-10 volunteers. If you have a free time on a Saturday afternoon and can help, please let us know.</p>
                </div>
            </div>                            
        </div>
        <!-- End Bordered Funny Boxes -->
    </div>
    <div class=""col-md-6"">
    
        <!-- Bordered Funny Boxes -->
        <div class=""funny-boxes funny-boxes-top-yellow"">
            <div class=""row"">
                <div class=""col-md-4 funny-boxes-img"">
                    <img class=""img-responsive"" src=""/assets/img/new/img11.jpg"" alt="""">
                </div>
                <div class=""col-md-8"">
                    <h2><a href=""#"">Participate in a Special Event</a></h2>
                    <p>We take advantage of several special event opportunities throughout the year. These events help us raise funds for our foster dogs which helps cover their medical expenses. They not only benefit the Labs, they are also fun. We have recently participated in the NASCAR races, agility shows and the Byron Nelson. We also host our annual Spring Fling and our annual Sporting Chance Golf Tournament.</p>
                </div>
            </div>                            
        </div>
        <!-- End Bordered Funny Boxes -->
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6"">
    
        <!-- Bordered Funny Boxes -->
        <div class=""funny-boxes funny-boxes-top-yellow"">
            <div class=""row"">
                <div class=""col-md-4 funny-boxes-img"">
                    <img class=""img-responsive"" src=""/assets/img/main/11.jpg"" alt="""">
                </div>
                <div class=""col-md-8"">
                    <h2><a href=""#"">Perform Home Studies in your area</a></h2>
                    <p>We receive applications from potential adopters from all over the Metroplex. Occasionally we do not have adequate coverage for some of the areas. This can result in delayed home studies for some applicants, something we want to avoid. If this interests you, please let us know. We can provide training with a seasoned volunteer until you are ready to do a few on your own.</p>
                </div>
            </div>                            
        </div>
        <!-- End Bordered Funny Boxes -->
    </div>
    <div class=""col-md-6"">
    
        <!-- Bordered Funny Boxes -->
        <div class=""funny-boxes funny-boxes-left-orange"">
            <div class=""row"">
                <div class=""col-md-4 funny-boxes-img"">
                    <img class=""img-responsive"" src=""/assets/img/dogs/committee.jpg"" alt="""">
                </div>
                <div class=""col-md-8"">
                    <h2><a href=""#"">Serve on a Committee or as an Event Coordinator</a></h2>
                    <p>We routinely post requests for committee members or event coordinators. These opportunities can range from fundraising to coordinating the volunteers, schedules and activities at special events such as our Spring Fling, the Sporting Chance Golf Tournament, the Byron Nelson or NASCAR. These are fun ways to get involved and meet fellow volunteers.</p>
                </div>
            </div>                            
        </div>
        <!-- End Bordered Funny Boxes -->
    </div>
</div>
<div class=""row"">
  <div class=""col-md-12"">
  <p class=""lead"">Do you have others ideas or want to help but have a limited schedule? If so, just let us know what interests you and how much time you have. We can find the perfect volunteer opportunity to fit your schedule. Even volunteering an afternoon or two every once in a while can make all the difference for a lab in need.</p>
  </div>	
</div>

    </div>
    <!-- End Content Part -->"
            };
        }

        private Content BuildFosterPage()
        {
            return new Content
            {
                ContentId = "Foster",
                Title = "Foster",
                CssFile = "/assets/css/pages/page_one.css",
                RawHtml = @"
    <!--=== Purchase Block ===-->
    <div class=""purchase"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-9 animated fadeInLeft"">
                    <span>Fosters provide a loving and caring place for our labs while we search for their forever home!</span>
					
                </div>            
                <div class=""col-md-3 btn-buy animated fadeInRight"">
                    <a href=""#"" class=""btn-u btn-u-lg""><i class=""fa fa-cloud-download""></i> Apply to Foster Now</a>
                </div>
            </div>
        </div>
    </div><!--/row-->
    <!-- End Purchase Block -->

    <!--=== Content Part ===-->
    <div class=""one-page"">
        <div class=""one-page-inner one-default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6"">
                <h1>What Types of Animals Need Foster Care?</h1>
                        <p>They arrive by the dozens every day: helpless Labs, who are sick, injured or abused...puppies who are too young up for adoption, great Labs that no one had time for pets whose families are in crisis, all surrendered to shelters in the DFW Metroplex!

To get the second chance they deserve, these Labs desperately need foster care.</p>
<p>
If you love and care about Labs and want to help them enjoy the lives they deserve, please become a DFW Lab Rescue foster-care provider today!

You may be asked to give a few days or weeks of your time to the dog who benefits, it means a lifetime.</p>
<p>""We need caring people to become foster care providers and help us save the lives of hundreds of Labs every year,"" said Director of Incoming Marisha Teagardin. ""The number of Labs needing rescue every day, every week, every month, and every year is staggering. We need people in our community to provide these Labs with temporary respite until they can be placed up for adoption and find their forever home.""</p>

                        <p>By providing temporary foster care to a Lab in need, you're helping to ensure a bright future. Without foster care, many Labs 
will not survive. There are little or no out-of-pocket costs to providing foster care, and you don't have to be an 'expert' about animals. 
DFWLRRC provides medication and veterinary care, foster training and support, and a fabulous ""Meet-N-Greet"" program. As a foster-care provider, 
you're asked to give love, food, care and time in a safe and nurturing environment. Each case is different. The length of time a Lab will spend in foster 
care depends upon that animal's age, and condition. The success of our organization is directly affected by the number of foster homes we have available. 
Fosters are essential in providing a loving environment for our rescued Labs, in order to assess their personalities and place them in forever homes. 
The more active foster homes we have on our roster, the more Labs we can give a new leash on life!</p>
                        <p>In ALL cases, you're giving a Lab the second chance he deserves.</p>
                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/dogs/weneedfosters_mammapups_full.jpg"" class=""img-responsive margin-bottom-10"" alt="""">
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-grey"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6"">
                <h1>Young or newborn puppies and pregnant females.</h1>
                        <p>With ""breeding season"" upon us, we need foster-care providers for Labs about to give birth to new litters of babies, 
as well as young and newborn puppies who are not old enough to go up for adoption. Some puppies, or litters, may require short-term bottle feeding;
most of these youngsters simply need a safe, secure home in which to ""grow up"" until they reach 8 weeks of age and a minimum of 10lbs.</p>

<p>Between May and September, shelters in the DFW Metroplex take in more than 3,000 unwanted puppies per month, many of them Labs! Many are too young and 
too small to go up for adoption and are euthanized, or fall ill and do not survive. But if given time to ""grow up"" in foster care, they can be spayed or 
neutered and placed up for adoption and get the chance to live a long, happy life.</p>

                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/dogs/weneedfosters_shelter.jpg"" class=""img-responsive"" alt="""">
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-grey"">
            <div class=""container"">
                <h1>Sick, injured or abused animals.</h1>
                <div class=""row margin-bottom-40"">
                    <div class=""col-md-6"">
                        <img src=""/assets/img/dogs/weneedfosters_injured.jpg"" class=""img-responsive"" alt="""">
                    </div>
                    <div class=""col-md-6"">
                        <p>Imagine having a very bad cold, a broken leg, a serious burn or other treatable medical condition, but no one to help or no place 
to go while you recovered. That is the fate of thousands of Labs who arrive at area shelters each year. Without a secure place to stay temporarily, and someone
to feed them and care for them (and in some cases, administer medication or change bandages) these Labs may not survive. Our Rescue vets work hard to give each
dog the same loving care you would want your pets to have, but there is a limit to how long they can house our injured Labs. New patients arrive every day; 
for them to receive the immediate, lifesaving care they need, we must move other recovering patients to another safe and nurturing location such as a temporary
foster-care home.</p>

<p>You don't have to be a veterinarian to care for a sick, injured or abused Lab. You simply need to provide tender, loving care under the direction of our 
Rescue Veterinarians and Vet Liaisons. It's important to note that we will never place a Lab patient with a foster-care provider who is not willing or able 
to provide the necessary level of care.</p>

                    </div>
                </div>
            </div>
        </div>
   <div class=""purchase"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-9 animated fadeInLeft"">
                    <span>Take the next Step! Please don't delay...Labs in need are waiting for you! Give a Lab a New Leash on Life!</span>
					
                </div>            
                <div class=""col-md-3 btn-buy animated fadeInRight"">
                    <a href=""#"" class=""btn-u btn-u-lg""><i class=""fa fa-cloud-download""></i> Apply to Foster Now</a>
                </div>
            </div>
        </div>
    </div>
    </div><!--/one-page-->
    <!-- End Content Part -->"
            };
        }


        private Content BuildDonationPage()
        {
            return new Content
            {
                ContentId = "Donations",
                Title = "Donations",
                Breadcrumbs = true,
                CssFile = "/assets/css/pages/page_pricing.css",
                RawHtml = @"
    <!--=== Content Part ===-->
    <div class=""container content"">
	<div class=""heading heading-v1 margin-bottom-20"">
            <h2>Donations to DFW Lab Rescue</h2>
            <p>Thank you for considering a donation to Dallas | Fort Worth Labrador Retriever Rescue Club, Inc. (DFWLRRC). Our rescue Labs and volunteers appreciate your interest in supporting this very special cause. Dallas | Fort Worth Labrador Retriever Rescue Club, incorporated in the state of Texas, is a non-profit, charitable 501(c)(3) organization. All contributions to DFWLRRC are tax deductible to the full extent of the law.</p>
        </div>
        <!-- Pricing -->
        <div class=""row margin-bottom-40"">
		<div class=""col-md-3 col-sm-6""></div>
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>One-Time<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
                        <p>Make a one time online donation through PayPal - you choose the amount. It's secure, it's fast, and it's free - just click ""Donate""!</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>Recurring<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
                        <p>Make a one time online donation through PayPal - you choose the amount. It's secure, it's fast, and it's free - just click ""Donate""!</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
			
		<div class=""col-md-3 col-sm-6""></div>
        </div><!--/row-->
         <hr class=""margin-bottom-60""/>
		 <div class=""heading heading-v1 margin-bottom-20"">
            <h2>Sponsor a Dog</h2>
            <p>To sponsor a dog, select a level of sponsorship. When checking out, in the comments field please specify the dog you wish to sponsor. All donations to DFWLRRC are acknowledged in writing. If your contribution is in honor of or in memory of an individual, or to commemorate a special occasion, an acknowledgement card will be sent to you or to anyone you designate. (Please note that all acknowledgments are written by DFWLRRC volunteers. Depending on their availability, it may take a few weeks for you or your designee to receive the card.)</p>
        </div>
		<div class=""row margin-bottom-40 pricing-light"">
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>Bronze Leash<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
						<h4><i>$</i>50</h4>
                        <p>Will pay for a week of boarding or one round of puppy shots.</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>Silver Leash<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
						<h4><i>$</i>100</h4>
                        <p>Will pay for exam & shots for adult dog or one Neuter (male).</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
		
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>Gold Leash<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
						<h4><i>$</i>200</h4>
                        <p>Will pay for one of our female Labs to be spayed.</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
        	<div class=""col-md-3 col-sm-6"">
                <div class=""pricing hover-effect"">
                    <div class=""pricing-head"">
                        <h3>Platinum Leash<span>Donation</span></h3>
                    </div>
                    <div class=""pricing-footer"">
						<h4><i>$</i>300</h4>
                        <p>Will pay for heart-worm treament for one of our Labs in need.</p>
                        <a class=""btn-u"" href=""#""><i class=""fa fa-shopping-cart""></i> Donate Now</a>
                    </div>                    
                </div>
            </div>
		</div>
        <!-- End Pricing -->


    </div><!--/container-->		
    <!--=== End Content Part ===-->"
            };
        }

        private Content BuildApplicationTermsPage()
        {
            return new Content
            {
                ContentId = "AdoptionProcess",
                Title = "Adoption Application Process",
                Breadcrumbs = true,
                CssFile = "/assets/css/pages/page_pricing.css",
                RawHtml = @"
    <!--=== Content Part ===-->
    <div class=""container content"">		
    	<div class=""row-fluid privacy"">
            <div id=""main_inner"">

<h2>The Process...</h2>

<h4>Overview of the DFWLRRC adoption process:</h4>

<ul>
	<li>A potential adopter completes the adoption application.</li>
	<li>DFWLRRC has the right to deny or refuse any application.&nbsp;</li>
	<li>If approved, the applicant is scheduled for a home study. The potential adopter is also added to our Meet n Greet invite list.&nbsp;</li>
	<li>If approved, the potential adopter is contacted by the Director of Adoptions with a list of foster dogs and how to contact their foster home. The potential adopter may also continue to attend the Meet n Greets.&nbsp;</li>
	<li>The potential adopter and foster home coordinate a time for the family to meet the dog, and if necessary, meet the existing family animals.</li>
	<li>Once a match is found, the adoption process is completed when the family completes the adoption contract, pays the adoption fee, and has secured the necessary items for the new family pet (leash, ID tag, crate, etc.)</li>
</ul>

<h4>Adoption Fees (Effective April 1, 2012):</h4>

<ul>
	<li>$350 for puppies (any dog under 6 months old when entering program)</li>
	<li>$275 for adults ($250 for adoptions completed prior to April 1st)</li>
</ul>

<p>On average, it takes between one and five months to adopt a Rescue Lab, depending on your personal circumstances and flexibility.
The adoption fees help us meet the boarding and veterinary expenses incurred by our non-profit organization, although our average expense per Lab is greater than the adoption donation.
Remember, DFWLRRC has the right to deny or refuse any application.</p>

<h4>Overview of the DFWLRRC rescue process:</h4>

<ul>
	<li>Once accepted into the program, but before he/she goes into a foster home, all new Labs get a trip to our veterinarian for complete checkups, required immunizations, heart worm tests/treatments, spaying or neutering (if necessary), and any medications prescribed by our vet.</li>
	<li>Once in a foster home, the rescue Lab is introduced to a warm, loving, safe environment. He/she will be crate trained, receive basic obedience training, and complete any necessary follow-up care prescribed by our vets. Our rescue Labs are treated like members of the family and receive all the spoils a Lab deserves.&nbsp;&nbsp;</li>
</ul>

<h4>Characteristics of a Forever Home:&nbsp;</h4>

<ul>
	<li>The dog will not be kept outdoors during the adopter's working hours, or at any other time left alone outdoors while the adopter is not at home. The dog may be confined to a room such as a bedroom or basement, or any other room of adequate size, and protected from the elements of weather</li>
	<li>Yard is securely fenced (Adoptions to apartment dwellers depend on the dog requested).</li>
	<li>Forever home is in the DFW area.&nbsp;</li>
	<li>No children under the age of 6, unless they have been raised with large dogs.</li>
	<li>Has an adult who wants to train and care for the dog&nbsp;</li>
	<li>Existing and recent pets must be spayed/neutered, on heartworm preventative, and current on all recommended vaccinations. (Please specify if there is a medical reason any of these conditions are not met)</li>
</ul>
</div>
        </div><!--/row-fluid-->        
    </div><!--/container-->		
    <!--=== End Content Part ===-->
	<div class=""purchase"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 animated fadeInLeft"">
                    <span> DFWLRRC is requesting a $25.00 fee for all adoption applications submitted. Your application will not be processed until this fee is received. This fee is non-refundable; all fees go towards meeting the needs of rescued Labrador Retrievers in our program. If you agree to all of the above, please fill out an adoption application today!</span>
					
                </div>            
                <div class=""col-md-4 btn-buy animated fadeInRight"">
                    <a href=""/Applications/Adoption"" class=""btn-u btn-u-lg""><i class=""fa fa-cloud-download""></i>Fill out Application</a>
                </div>
            </div>
        </div>
    </div>"
            };
        }
    }
}
