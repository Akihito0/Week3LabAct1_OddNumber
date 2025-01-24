namespace Week3LabAct1_OddNumber
{
    public partial class Form1 : Form
    {
        public static string gender = "", age, maritalStatus, incomeRange, employmentStatus, education;
        public static string oftenexercise, usesports, lastbuy, describe, describepurpose="", wherebuy, prefdesign, influence,
            rateWT, rateCool, rateAntibac, rateAntiOd, rateSoft, rateElas, rateEndu, favesports, otherinterest, email;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            genderAnswers();
            ageAnswers();
            maritalStatusAnswers();
            incomeRangeAnswers();
            educationAnswers();
            oftenexerciseAnswers();
            usesportsAnswers();
            lastbuyAnswers();
            describepurposeAnswers();
            usuallybuyAnswers();
            influenceAnswers();
            getwaterRating();
            getcoolingRating();
            getantibacRating();
            getantiOdRating();
            getsoftRating();
            getelasRating();
            getenduRating();
            getfavesports();
            getotherinterest();
            getemail();
            MessageBox.Show(@$"Answers Successfully Submitted!
Thank you for participating in our survey!

Here are your answers:
Gender: {gender}
Age: {age}
Marital Status: {maritalStatus}
Income Range: {incomeRange}
Emploment Status: {employmentStatus}
Education: {education}
How often do you exercise: {oftenexercise}
How often do you use sports apparel: {usesports}
When did you last buy a sportswear: {lastbuy}
Which of the following would describe the purpose to buy a sportswear: {describepurpose}
Where do you usually buy your sportswear: {wherebuy}
What is your preferred design: {prefdesign}
Which of the following factors influence your decision to buy a sportswear: {influence}
Water Rating: {rateWT} Cooling Rating: {rateCool} Antibacterial Rating: {rateAntibac}
Anti-Odor Rating: {rateAntiOd} Softness Rating: {rateSoft} Elasticity Rating: {rateElas}
Endurance Rating: {rateEndu}
If person was favourite sports: {favesports}
Other interest: {otherinterest}
E - Mail: {email}
");
        }
        public void getemail() 
        {
            email = txtbxEmail.Text;
        }
        public void getotherinterest() 
        {
            if (chkbxArts.Checked) 
            {
                otherinterest += " " + chkbxArts.Text;
            }
            if (chkbxBooks.Checked) 
            {
                otherinterest += " " + chkbxBooks.Text;
            }
            if (chkbxFinance.Checked) 
            {
                otherinterest += " " + chkbxFinance.Text;
            }
            if (chkbxHobbies.Checked) 
            {
                otherinterest += " " + chkbxHobbies.Text;
            }
            if (chkbxJobs.Checked) 
            {
                otherinterest += " " + chkbxJobs.Text;
            }
            if (chkbxShopping.Checked) 
            {
                otherinterest += " " + chkbxShopping.Text;
            }
            if (chkbxMotor.Checked) 
            {
                otherinterest += " " + chkbxMotor.Text;
            }
            if (chkbxAuto.Checked) 
            {
                otherinterest += " " + chkbxAuto.Text;
            }
            if (chkbxBusiness.Checked) 
            {
                otherinterest += " " + chkbxBusiness.Text;
            }
            if (chkbxFood.Checked) 
            {
                otherinterest += " " + chkbxFood.Text;
            }
            if (chkbxHome.Checked) 
            {
                otherinterest += " " + chkbxHome.Text;
            }
            if (chkbxLaw.Checked) 
            {
                otherinterest += " " + chkbxLaw.Text;
            }
            if (chkbxPeople.Checked) 
            {
                otherinterest += " " + chkbxPeople.Text;
            }
            if (chkbxRef.Checked) 
            {
                otherinterest += " " + chkbxRef.Text;
            }
            if (chkbxTravel.Checked) 
            {
                otherinterest += " " + chkbxTravel.Text;
            }
            if (chkbxEsports.Checked) 
            {
                otherinterest += " " + chkbxEsports.Text;
            }
            if (chkbxBeauty.Checked) 
            {
                otherinterest += " " + chkbxBeauty.Text;
            }
            if (chkbxComputers.Checked) 
            {
                otherinterest += " " + chkbxComputers.Text;
            }
            if (chkbxGames.Checked) 
            {
                otherinterest += " " + chkbxGames.Text;
            }
            if (chkbxInternet.Checked) 
            {
                otherinterest += " " + chkbxInternet.Text;
            }
            if (chkbxNews.Checked) 
            {
                otherinterest += " " + chkbxNews.Text;
            }
            if (chkbxPet.Checked) 
            {
                otherinterest += " " + chkbxPet.Text;
            }
            if (chkbxScience.Checked) 
            {
                otherinterest += " " + chkbxScience.Text;
            }
            if (chkbxWorld.Checked) 
            {
                otherinterest += " " + chkbxWorld.Text;
            }
        }
         public void getfavesports() 
        {
            if (chkbxImaginative.Checked) 
            {
                favesports += " " + chkbxImaginative.Text;
            }    
            if (chkbxColorful.Checked) 
            {
                favesports += " " + chkbxColorful.Text;
            }    
            if (chkbxCheerful.Checked) 
            {
                favesports += " " + chkbxCheerful.Text;
            }
            if (chkbxDaring.Checked) 
            {
                favesports += " " + chkbxDaring.Text;
            }  
            if (chkbxIntelligent.Checked) 
            {
                favesports += " " + chkbxIntelligent.Text;
            }  
            if (chkbxTough.Checked) 
            {
                favesports += " " + chkbxTough.Text;
            }  
            if (chkbxSerious.Checked) 
            {
                favesports += " " + chkbxSerious.Text;
            }  
            if (chkbxSpirited.Checked) 
            {
            favesports += " " + chkbxSpirited.Text;
            }  
            if (chkbxOutdoorsy.Checked) 
            {
                favesports += " " + chkbxOutdoorsy.Text;
            }  
            if (chkbxReliable.Checked) 
            {
                favesports += " " + chkbxReliable.Text;
            }  
            if (chkbxHonest.Checked) 
            {
                favesports += " " + chkbxHonest.Text;
            }  
            if (chkbxOther.Checked) 
            {
                favesports += " " + chkbxOther.Text;
            }  
            if (chkbxFunny.Checked) 
            {
                favesports += " " + chkbxFunny.Text;
            }  
            if (chkbxSuccessful.Checked) 
            {
                favesports += " " + chkbxSuccessful.Text;
            }  
            if (chkbxIntrovert.Checked) 
            {
                favesports += " " + chkbxIntrovert.Text;
            }  
            if (chkbxSophisticated.Checked) 
            {
                favesports += " " + chkbxSophisticated.Text;
            }  
            if (chkbxClassy.Checked) 
            {
                favesports += " " + chkbxClassy.Text;
            }  
        }
        public void getenduRating() 
        {
              if (radbtnEndu1.Checked) 
            {
                rateEndu = radbtnEndu1.Text;
            }
            else if (radbtnEndu2.Checked) 
            {
                rateEndu = radbtnEndu2.Text;
            }
             else if (radbtnEndu3.Checked) 
            {
                rateEndu = radbtnEndu3.Text;
            }
             else if (radbtnEndu4.Checked) 
            {
                rateEndu = radbtnEndu4.Text;
            }
             else if (radbtnEndu5.Checked) 
            {
                rateEndu = radbtnEndu5.Text;
            }
        }
        public void getelasRating() 
        {
              if (radbtnElas1.Checked) 
            {
                rateElas = radbtnElas1.Text;
            }
            else if (radbtnElas2.Checked) 
            {
                rateElas = radbtnElas2.Text;
            }
             else if (radbtnElas3.Checked) 
            {
                rateElas = radbtnElas3.Text;
            }
             else if (radbtnElas4.Checked) 
            {
                rateElas = radbtnElas4.Text;
            }
             else if (radbtnElas5.Checked) 
            {
                rateElas = radbtnElas5.Text;
            }
        }
        public void getsoftRating() 
        {
            if (radbtnSmooth1.Checked) 
            {
                rateSoft = radbtnSmooth1.Text;
            }
            else if (radbtnSmooth2.Checked) 
            {
                rateSoft = radbtnSmooth2.Text;
            }
             else if (radbtnSmooth3.Checked) 
            {
                rateSoft = radbtnSmooth3.Text;
            }
             else if (radbtnSmooth4.Checked) 
            {
                rateSoft = radbtnSmooth4.Text;
            }
             else if (radbtnSmooth5.Checked) 
            {
                rateSoft = radbtnSmooth5.Text;
            }
        }
        public void getantiOdRating() 
        {
            if (radbtnAntiOd1.Checked) 
            {
                rateAntiOd = radbtnAntiOd1.Text;
            }
            else if (radbtnAntiOd2.Checked) 
            {
                rateAntiOd = radbtnAntiOd2.Text;
            }
             else if (radbtnAntiOd3.Checked) 
            {
                rateAntiOd = radbtnAntiOd3.Text;
            }
             else if (radbtnAntiOd4.Checked) 
            {
                rateAntiOd = radbtnAntiOd4.Text;
            }
             else if (radbtnAntiOd5.Checked) 
            {
                rateAntiOd = radbtnAntiOd5.Text;
            }
        }
        public void getantibacRating() 
        {
            if (radbtnAntiBac1.Checked) 
            {
                rateAntibac = radbtnAntiBac1.Text;
            }
            else if (radbtnAntiBac2.Checked) 
            {
                rateAntibac = radbtnAntiBac2.Text;
            }
             else if (radbtnAntiBac3.Checked) 
            {
                rateAntibac = radbtnAntiBac3.Text;
            }
             else if (radbtnAntiBac4.Checked) 
            {
                rateAntibac = radbtnAntiBac4.Text;
            }
             else if (radbtnAntiBac5.Checked) 
            {
                rateAntibac = radbtnAntiBac5.Text;
            }
        }
        public void getcoolingRating() 
        {
            if (radbtnCool1.Checked) 
            {
                rateCool = radbtnCool1.Text;
            }
            else if (radbtnCool2.Checked) 
            {
                rateCool = radbtnCool2.Text;
            }
             else if (radbtnCool3.Checked) 
            {
                rateCool = radbtnCool3.Text;
            }
             else if (radbtnCool4.Checked) 
            {
                rateCool = radbtnCool4.Text;
            }
             else if (radbtnCool5.Checked) 
            {
                rateCool = radbtnCool5.Text;
            }
        }
        public void getwaterRating() 
        {
            if (radbtnWtrRes5.Checked) 
            {
                rateWT = radbtnWtrRes5.Text;
            }
            else if (radbtnWtrRes4.Checked) 
            {
                rateWT = radbtnWtrRes4.Text;
            }
             else if (radbtnWtrRes3.Checked) 
            {
                rateWT = radbtnWtrRes3.Text;
            }
             else if (radbtnWtrRes2.Checked) 
            {
                rateWT = radbtnWtrRes2.Text;
            }
             else if (radbtnWtrRes1.Checked) 
            {
                rateWT = radbtnWtrRes1.Text;
            }
        }
        public void prefdesignAnswers() 
        {
            if (chkbxMinimalist.Checked) 
            {
                prefdesign += " " + chkbxMinimalist.Text;
            }    
            if (chkbxSlogan.Checked) 
            {
                prefdesign += " " + chkbxSlogan.Text;
            }    
            if (chkbxBold.Checked) 
            {
                prefdesign += " " + chkbxBold.Text;
            }
            if (chkbxOther2.Checked) 
            {
                prefdesign += " " + chkbxOther2.Text;
            }  
        }
        public void influenceAnswers() 
        {
            if (chkbxPrice.Checked) 
            {
                influence += " " + chkbxPrice.Text;
            }
            if (chkbxValue.Checked) 
            {
                influence += " " + chkbxValue.Text;
            }
            if (chkbxOther1.Checked) 
            {
                influence += " " + chkbxOther1.Text;
            }
            if (chkbxwQuality.Checked) 
            {
                influence += " " + chkbxwQuality.Text;
            }
            if (chkbxBrand.Checked) 
            {
                influence += " " + chkbxBrand.Text;
            }
        }
        public void usuallybuyAnswers() 
        {
            if (chkbxRetail.Checked)
            {
                wherebuy += " " + chkbxRetail.Text;
            }
            if (chkbxMulti.Checked) 
            {
                wherebuy += " " + chkbxMulti.Text;
            }
            if (chkbxDepartment.Checked)
            {
                wherebuy += " " + chkbxDepartment.Text;
            }
            if (chkbxOnline1.Checked) 
            {
                wherebuy += " " + chkbxOnline1.Text;
            }
            if (chkbxOther3.Checked) 
            {
                wherebuy += " " + chkbxOther3.Text;
            }
        }
        public void describepurposeAnswers()
        {
            if (chkbxGym.Checked == true)
            {
                describepurpose += " " + chkbxGym.Text;
            }
            if (chkbxHiking.Checked)
            {
                describepurpose += " " + chkbxHiking.Text;
            }
            if (chkbxSports.Checked)
            {
               describepurpose += " " + chkbxSports.Text;
            }
            if (chkbxRunning.Checked)
            {
                describepurpose += " " + chkbxRunning.Text;
            }
            if (chkbxOutdoor.Checked)
            {
               describepurpose += " " + chkbxOutdoor.Text;
            }
            if (chkbxOthers4.Checked)
            {
                describepurpose += " " + chkbxOthers4.Text;
            }
        }
        public void lastbuyAnswers()
        {
            if (radbtnless1.Checked)
            {
                lastbuy = radbtnless1.Text;
            }
            else if (radbtn16.Checked)
            {
                lastbuy = radbtn16.Text;
            }
            else if (radbtn61.Checked)
            {
                lastbuy = radbtn61.Text;
            }
            else if (radbtnmore1.Checked)
            {
                lastbuy = radbtnmore1.Text;
            }
            else if (radbtninvalid.Checked)
            {
                lastbuy = radbtninvalid.Text;
            }
        }
        public void usesportsAnswers() 
        {
            if (radbtnoften1.Checked)
            {
                oftenexercise = radbtnoften1.Text;
            }
            else if (radbtnoften2.Checked)
            {
                oftenexercise = radbtnoften2.Text;
            }
             else if (radbtnoften3.Checked)
            {
                oftenexercise = radbtnoften3.Text;
            }
             else if (radbtnoften4.Checked)
            {
                oftenexercise = radbtnoften4.Text;
            }
             else if (radbtnoften5.Checked)
            {
                oftenexercise = radbtnoften5.Text;
            }
             else if (radbtnoften6.Checked)
            {
                oftenexercise = radbtnoften6.Text;
            }
             else if (radbtnoften7.Checked)
            {
                oftenexercise = radbtnoften7.Text;
            }
             else if (radbtnoften8.Checked)
            {
                oftenexercise = radbtnoften8.Text;
            }
             else if (radbtnoften9.Checked)
            {
                oftenexercise = radbtnoften9.Text;
            }
             else if (radbtnoften10.Checked)
            {
                oftenexercise = radbtnoften10.Text;
            }
        }
        public void oftenexerciseAnswers()
        {
            if (radbtnoftenexe1.Checked)
            {
                oftenexercise = radbtnoftenexe1.Text;
            }
            else if (radbtnoftenexe2.Checked)
            {
                oftenexercise = radbtnoftenexe2.Text;
            }
             else if (radbtnoftenexe3.Checked)
            {
                oftenexercise = radbtnoftenexe3.Text;
            }
             else if (radbtnoftenexe4.Checked)
            {
                oftenexercise = radbtnoftenexe4.Text;
            }
             else if (radbtnoftenexe5.Checked)
            {
                oftenexercise = radbtnoftenexe5.Text;
            }
             else if (radbtnoftenexe6.Checked)
            {
                oftenexercise = radbtnoftenexe6.Text;
            }
             else if (radbtnoftenexe7.Checked)
            {
                oftenexercise = radbtnoftenexe7.Text;
            }
             else if (radbtnoftenexe8.Checked)
            {
                oftenexercise = radbtnoftenexe8.Text;
            }
             else if (radbtnoftenexe9.Checked)
            {
                oftenexercise = radbtnoftenexe9.Text;
            }
             else if (radbtnoftenexe10.Checked)
            {
                oftenexercise = radbtnoftenexe10.Text;
            }
        }
        public void genderAnswers()
        {
            if (radbtnFemale.Checked)
            {
                gender = radbtnFemale.Text;
            }
            else if (radbtnFemale.Checked)
            {
                gender = radbtnMale.Text;
            }
            else if (radbtnNonbinary.Checked) 
            {
                gender = radbtnNonbinary.Text;
            }
            else if (radbtnNA.Checked) 
            {
                gender = radbtnNA.Text;
            }
        }
        public void ageAnswers()
        {
            if (radbtn17.Checked)
            {
                age = radbtn17.Text;
            }
            else if (radbtn24.Checked)
            {
                age = radbtn24.Text;
            }
            else if (radbtn34.Checked)
            {
                age = radbtn34.Text;
            }
            else if (radbtn54.Checked)
            {
                age = radbtn54.Text;
            }
            else if (radbtn44.Checked)
            {
                age = radbtn44.Text;
            }
            else if (radbtn64.Checked)
            {
                age = radbtn64.Text;
            }
            else if (radbtn65.Checked)
            {
                age = radbtn65.Text;
            }
        }
        public void maritalStatusAnswers()
        {
            if (radbtnsingle.Checked)
            {
                maritalStatus = radbtnsingle.Text;
            }
            else if (radbtnmarried.Checked)
            {
                maritalStatus = radbtnmarried.Text;
            }
            else if (radbtndivorced.Checked)
            {
                maritalStatus = radbtndivorced.Text;
            }
            else if (radbtnwidowed.Checked)
            {
                maritalStatus = radbtnwidowed.Text;
            }
            else if (radbtninvalid4.Checked)
            {
                maritalStatus = radbtninvalid4.Text;
            }
        }
        public void incomeRangeAnswers()
        {
            if (radbtn10k.Checked)
            {
                incomeRange = radbtn10k.Text;
            }
            else if (radbtn9k.Checked)
            {
                incomeRange = radbtn9k.Text;
            }
            else if (radbtn75k.Checked)
            {
                incomeRange = radbtn75k.Text;
            }
            else if (radbtn25k.Checked)
            {
                incomeRange = radbtn25k.Text;
            }
            else if (radbtn50k.Checked)
            {
                incomeRange = radbtn50k.Text;
            }
            else if (radbtn100k.Checked)
            {
                incomeRange = radbtn100k.Text;
            }
            else if (radbtninvalid3.Checked) 
            {
                incomeRange = radbtninvalid3.Text;
            }
        }
        public void employmentStatusAnswers()
        {
            if (radbtnemp.Checked)
            {
                employmentStatus = radbtnemp.Text;
            }
            else if (radbtnempptr.Checked)
            {
                employmentStatus = radbtnempptr.Text;
            }
            else if (radbtnselfemp.Checked)
            {
                employmentStatus = radbtnselfemp.Text;
            }
            else if (radbtnunemp.Checked)
            {
                employmentStatus = radbtnunemp.Text;
            }
            else if (radbtnstud.Checked)
            {
                employmentStatus = radbtnstud.Text;
            }
            else if (radbtnotlooking.Checked)
            {
                employmentStatus = radbtnotlooking.Text;
            }
            else if (radbtninvalid2.Checked)
            {
                employmentStatus = radbtninvalid2.Text;
            }
        }
        public void educationAnswers()
        {
            if (radbtnless.Checked)
            {
                education = radbtnless.Text;
            }
            else if (radbtnsome.Checked)
            {
                education = radbtnsome.Text;
            }
            else if (radbtnunder.Checked)
            {
                education = radbtnunder.Text;
            }
            else if (radbtndoc.Checked)
            {
                education = radbtndoc.Text;
            }
            else if (radbtnhigh.Checked)
            {
                education = radbtnhigh.Text;
            }
            else if (radbtncollege.Checked)
            {
                education = radbtncollege.Text;
            }
            else if (radbtnmaster.Checked)
            {
                education = radbtnmaster.Text;
            }
            else if (radbtninvalid1.Checked) 
            {
             education = radbtninvalid1.Text;
            }
        }
    }
}
