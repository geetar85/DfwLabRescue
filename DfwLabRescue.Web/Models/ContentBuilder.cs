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

            return contentList;
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
                <h1>What Types of Animals Need Foster Care?</h1>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>They arrive by the dozens every day: helpless Labs, who are sick, injured or abused...puppies who are too young up for adoption, great Labs that no one had time for pets whose families are in crisis, all surrendered to shelters in the DFW Metroplex!

To get the second chance they deserve, these Labs desperately need foster care.</p>
<p>
If you love and care about Labs and want to help them enjoy the lives they deserve, please become a DFW Lab Rescue foster-care provider today!

You may be asked to give a few days or weeks of your time to the dog who benefits, it means a lifetime.</p>
<p>""We need caring people to become foster care providers and help us save the lives of hundreds of Labs every year,"" said Director of Incoming Marisha Teagardin. ""The number of Labs needing rescue every day, every week, every month, and every year is staggering. We need people in our community to provide these Labs with temporary respite until they can be placed up for adoption and find their forever home.""</p>
                        <a class=""btn-u btn-u-green one-page-btn""><i class=""fa fa-bolt""></i> libero adipiscing</a>
                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/new/img5.jpg"" class=""img-responsive margin-bottom-10"" alt="""">
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-blue"">
            <div class=""container"">
                <h1>At vero eos et accusamus et iusto odio dignissimos</h1>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <img src=""/assets/img/new/img1.jpg"" class=""margin-bottom-10 img-responsive"" alt="""">
                    </div>
                    <div class=""col-md-6"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero consectetur adipiscing elit magna. Sed et quam lacus..</p>
                        <p>Fusce condimentum eleifend enim a feugiat. Pellentesque viverra vehicula sem ut volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero magna. Sed et quam lacus. Fusce condimentum eleifend enim a feugiat.</p>
                        <a class=""btn-u btn-u-red one-page-btn""><i class=""fa fa-bell""></i> libero adipiscing</a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-grey"">
            <div class=""container"">
                <h1>Molestias excepturi sint occaecati cupiditate</h1>
                <div class=""row margin-bottom-40"">
                    <div class=""col-md-6"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero consectetur adipiscing elit magna. Sed et quam lacus..</p>
                        <p>Fusce condimentum eleifend enim a feugiat. Pellentesque viverra vehicula sem ut volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero magna. Sed et quam lacus. Fusce condimentum eleifend enim a feugiat.</p>
                        <a class=""btn-u btn-u-blue one-page-btn""><i class=""fa fa-bullhorn""></i> libero adipiscing</a>
                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/new/img7.jpg"" class=""img-responsive"" alt="""">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <img src=""/assets/img/new/img6.jpg"" class=""margin-bottom-20 img-responsive"" alt="""">
                    </div>
                    <div class=""col-md-6"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero consectetur adipiscing elit magna. Sed et quam lacus..</p>
                        <p>Fusce condimentum eleifend enim a feugiat. Pellentesque viverra vehicula sem ut volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero magna. Sed et quam lacus. Fusce condimentum eleifend enim a feugiat.</p>
                        <a class=""btn-u btn-u-orange one-page-btn""><i class=""fa fa-briefcase""></i> libero adipiscing</a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-red"">
            <div class=""container"">
                <h1>At vero eos et accusamus et iusto odio dignissimos</h1>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero consectetur adipiscing elit magna. Sed et quam lacus..</p>
                        <p>Fusce condimentum eleifend enim a feugiat. Pellentesque viverra vehicula sem ut volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero magna. Sed et quam lacus. Fusce condimentum eleifend enim a feugiat.</p>
                        <a class=""btn-u btn-u-green one-page-btn""><i class=""fa fa-comments-o""></i> libero adipiscing</a>
                    </div>
                    <div class=""col-md-6"">
                        <img src=""/assets/img/new/img10.jpg"" class=""img-responsive margin-bottom-10"" alt="""">
                    </div>
                </div>
            </div>
        </div>

        <div class=""one-page-inner one-default"">
            <div class=""container"">
                <h1>At vero eos et accusamus et iusto odio dignissimos</h1>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <img src=""/assets/img/main/8.jpg"" class=""img-responsive margin-bottom-10"" alt="""">
                    </div>
                    <div class=""col-md-6"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero consectetur adipiscing elit magna. Sed et quam lacus..</p>
                        <p>Fusce condimentum eleifend enim a feugiat. Pellentesque viverra vehicula sem ut volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non libero magna. Sed et quam lacus. Fusce condimentum eleifend enim a feugiat.</p>
                        <div class=""row margin-bottom-20"">
                            <div class=""col-md-3"">
                                <a href=""/assets/img/main/1.jpg"" title=""Project #2"" data-rel=""fancybox-button"" class=""thumbnail fancybox-button zoomer"">
                                    <span class=""overlay-zoom"">  
                                        <img class=""img-responsive"" src=""/assets/img/main/1.jpg"" alt="""" />
                                        <div class=""zoom-icon""></div>                   
                                    </span>                                              
                                </a>
                            </div>
                            <div class=""col-md-3"">
                                <a href=""/assets/img/main/2.jpg"" title=""Project #2"" data-rel=""fancybox-button"" class=""thumbnail fancybox-button zoomer"">
                                    <span class=""overlay-zoom"">  
                                        <img class=""img-responsive"" src=""/assets/img/main/2.jpg"" alt="""" />
                                        <div class=""zoom-icon""></div>                   
                                    </span>                                              
                                </a>                                                                                    
                            </div>
                            <div class=""col-md-3"">
                                <a href=""/assets/img/main/3.jpg"" title=""Project #2"" data-rel=""fancybox-button"" class=""thumbnail fancybox-button zoomer"">
                                    <span class=""overlay-zoom"">  
                                        <img class=""img-responsive"" src=""/assets/img/main/3.jpg"" alt="""" />
                                        <div class=""zoom-icon""></div>                   
                                    </span>                                              
                                </a>                                                                                    
                            </div>
                            <div class=""col-md-3"">
                                <a href=""/assets/img/main/4.jpg"" title=""Project #2"" data-rel=""fancybox-button"" class=""thumbnail fancybox-button zoomer"">
                                    <span class=""overlay-zoom"">  
                                        <img class=""img-responsive"" src=""/assets/img/main/4.jpg"" alt="""" />
                                        <div class=""zoom-icon""></div>                   
                                    </span>                                              
                                </a>                                                                                    
                            </div>
                        </div>
                        <a class=""btn-u btn-u-red one-page-btn""><i class=""fa fa-thumbs-up""></i> libero adipiscing</a>
                    </div>
                </div>
                <hr>
                <div class=""row"">
                   <div class=""col-md-3"">
                      <h3 class=""heading-sm""><a href=""#"">Consectetur adipiscing</a></h3>
                      <p>Pellentesque viverra vehicula sem ut volutpat dosum molor sit amet, consectetur adipiscing elit</p>
                   </div>
                   <div class=""col-md-3"">
                      <h3 class=""heading-sm""><a href=""#"">Ut volutpat dosum</a></h3>
                      <p>Lunt in lpa qui officia deserunt mollitia mo animi, asmid leoff iscia est labor le harum quidem rerum facilis</p>
                   </div>
                   <div class=""col-md-3"">
                      <h3 class=""heading-sm""><a href=""#"">Viverra de esque</a></h3>
                      <p>Volutpat dosum esque viverra ved et quam lacusehicula sem ut  molorviverra sit amet, consetetur edipiscin la</p>
                   </div>
                   <div class=""col-md-3"">
                      <h3 class=""heading-sm""><a href=""#"">Sem ut volutpat dum</a></h3>
                      <p>Deleniti atque corrupa vehicula sem ut volutpat dosum molor sit amet, consectetur adipiscing praesentium</p>
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
                ContentId = "AdoptionTerms",
                Title = "Adoption Terms",
                Breadcrumbs = true,
                CssFile = "/assets/css/pages/page_pricing.css",
                RawHtml = @""
            };
        }
    }
}
