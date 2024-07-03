using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            IEnumerable<Exercise> exercises = GetNeckExercises()
                .Concat(GetTrapeziusExercises())
                .Concat(GetShoulderExercises())
                .Concat(GetChestExercises())
                .Concat(GetBackExercises())
                .Concat(GetBicepsExercises())
                .Concat(GetTricepsExercises())
                .Concat(GetForearmExercises())
                .Concat(GetAbsExercises())
                .Concat(GetLegsExercises())
                .Concat(GetCalvesExercises())
                .Concat(GetFullBodyExercises());

            builder.HasData(exercises);
        }

        private int StartingIndex { get; set; } = 1;

        private IEnumerable<Exercise> GetNeckExercises()
        {
            return
            [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Weighted Lying Neck Extension",
                    Explanation =
                        "This exercise is an effective neck exercise designed to develop and strengthen the muscles at the back of your neck. Thanks to its strong neck muscles, it makes the neck much more versatile, increasing the range of motion, relaxing the neck and making it strong against injuries.",
                    PerformTip =
                        "Lie on your back with your head hanging off a bench. Start with your head in a neutral position. Lower the weight behind your head while keeping your neck straight. Raise the weight back to the starting position by flexing your neck. Breathe in as you lower the weight, and exhale as you lift it. Start with light weights and gradually increase as you get comfortable. Avoid using excessive weight or jerky motions to prevent strain or injury.",
                    ImageName = "WeightedLyingNeckExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Lying Weighted Neck Flexion",
                    Explanation =
                        "The Lying Weighted Neck Flexion primarily targets the muscles in the front of your neck, known as the neck flexors. Strengthening these muscles can improve neck stability and help alleviate neck pain or tension. Additionally, this exercise can enhance overall neck strength, which is beneficial for activities requiring neck stabilization, such as lifting weights or maintaining proper posture during daily activities. By regularly incorporating this exercise into your routine, you can promote better neck health and reduce the risk of injury.",
                    PerformTip =
                        "To perform the Lying Weighted Neck Flexion effectively, lie on a flat bench with your head positioned just off the edge. The bench should be at a slight incline, allowing your head to move freely. Hold a weight plate or dumbbell securely against your forehead, ensuring it doesn't slip during the movement. Slowly lower your head towards your chest while maintaining control and a smooth motion. Aim to lower your head to a comfortable range of motion, feeling a stretch in your neck muscles. Then, slowly raise your head back to the starting position. Focus on using your neck muscles to lift the weight rather than relying on momentum. Start with a light weight to master the technique, and gradually increase the resistance as you become more proficient. Remember to breathe steadily throughout the exercise and avoid straining your neck by using excessive weight or jerking motions.",
                    ImageName = "LyingWeightedNeckFlexion.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Lying Weighted Neck Extension",
                    Explanation =
                        "The Lying Weighted Neck Extension targets the muscles at the back of your neck, known as the neck extensors. Strengthening these muscles can improve neck stability and posture, reducing the likelihood of neck pain or discomfort. Additionally, this exercise helps counterbalance the effects of forward head posture, which is common in individuals who spend long periods sitting or looking down at screens. By incorporating this exercise into your routine, you can enhance neck strength and resilience, leading to better overall neck health.",
                    PerformTip =
                        "To perform the Lying Weighted Neck Extension effectively, lie on your stomach on a flat bench with your head positioned just off the edge. The bench should be at a slight incline, allowing your head to move freely. Hold a weight plate or dumbbell securely against your head, ensuring it doesn't slip during the movement. Slowly raise your head while maintaining control and a smooth motion. Aim to lower your head to a comfortable range of motion. Then, slowly raise your head back to a comfortable position using your neck muscles. Avoid using momentum or jerking motions, and start with a light weight to master the technique before progressing to heavier weights. Remember to breathe steadily throughout the exercise and stop if you experience any discomfort or pain.",
                    ImageName = "LyingWeightedNeckExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Chin Tuck",
                    Explanation =
                        "The Chin Tuck is a simple yet effective exercise for improving neck posture and reducing neck pain. It targets the deep cervical flexor muscles, which play a crucial role in stabilizing the neck and supporting proper alignment. By regularly practicing the Chin Tuck, you can counteract the effects of forward head posture, a common issue associated with modern sedentary lifestyles and excessive screen time. This exercise helps strengthen the muscles at the front of the neck while stretching the muscles at the back, promoting better neck alignment and relieving strain on the cervical spine. Additionally, the Chin Tuck can alleviate tension headaches and improve overall neck mobility, leading to enhanced comfort and well-being.",
                    PerformTip =
                        "While looking straight ahead, place two fingers on your chin, slightly tuck your chin and move your head back . Hold for 3-5 seconds and then release.",
                    ImageName = "ChinTuck.gif",
                },
            ];
        }

        private IEnumerable<Exercise> GetTrapeziusExercises()
        {
            return [
             new Exercise
             {
                 Id = StartingIndex++,
                 Name = "Dumbbell Shrug",
                 Explanation = "Dumbbell shrugs are an exercise that primarily targets the trapezius muscles, which are located on the upper back and neck area. Overall, dumbbell shrugs are a simple yet effective exercise that can provide many benefits for your overall fitness. Whether you’re a beginner or an experienced gym-goer, adding dumbbell shrugs to your workout routine can help you achieve your fitness goals.",
                 PerformTip = "It’s important to start with a weight that you can comfortably control with proper form. As you get comfortable with the exercise, you can gradually increase the weight. Stand with your feet shoulder-width apart, and keep your back straight and your shoulders relaxed. Hold a dumbbell in each hand with your palms facing your body. Your arms should be straight down at your sides. Slowly lift your shoulders straight up towards your ears as high as possible, keeping your arms straight. Make sure to use your scapula and traps to lift the weight, not your biceps or your neck. Hold the top position for a moment, making sure to contract your traps fully. Slowly lower the dumbbells back down to the starting position, keeping your arms straight.",
                 ImageName = "DumbbellShrug.gif",
             },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Shrug",
                    Explanation = "The focus of the barbell shrug exercise is the trapezius muscles. Barbell shrug is the most important exercise for developing strength in the trapezius muscles as it fully activates the muscle fibers in the upper back.",
                    PerformTip = "To perform the Barbell Shrug with proper form, stand tall with your feet shoulder-width apart and hold a barbell in front of your thighs using an overhand grip, slightly wider than shoulder-width apart. Allow your arms to fully extend, keeping a slight bend in your elbows. Engage your core muscles to maintain a stable torso throughout the exercise. Initiate the movement by elevating your shoulders as high as possible towards your ears, focusing on contracting the upper traps. Hold the top position for a brief moment to maximize muscle contraction. Avoid rolling your shoulders forward or backward, and keep the movement vertical to target the upper traps effectively. Lower the barbell back to the starting position under control, allowing your shoulders to fully depress without rounding your upper back. Perform the exercise with a smooth and controlled motion, avoiding any jerking or swinging of the weight. Use an appropriate weight that allows you to complete the desired number of repetitions with proper form and without compromising safety.",
                    ImageName = "BarbellShrug.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Behind The Back Barbell Shrug",
                    Explanation = "The Behind The Back Barbell Shrug targets the trapezius muscles, primarily focusing on the mid to lower traps. By performing this exercise, you can effectively strengthen and develop these muscles, which play a crucial role in shoulder stabilization and posture. Strong mid and lower traps contribute to better shoulder health, reducing the risk of shoulder injuries and improving overall upper body function.",
                    PerformTip = "To perform the Behind The Back Barbell Shrug with proper form, stand tall with your feet shoulder-width apart and hold a barbell behind your body using an overhand grip, with your palms facing away from you. Allow your arms to fully extend downward, keeping a slight bend in your elbows. Engage your core muscles to maintain a stable torso throughout the exercise. Initiate the movement by elevating your shoulders as high as possible towards your ears, focusing on contracting the mid to lower traps. Hold the top position for a brief moment to maximize muscle contraction. Avoid arching your lower back or leaning forward excessively during the movement. Lower the barbell back to the starting position under control, allowing your shoulders to fully depress without rounding your upper back. Perform the exercise with a smooth and controlled motion, avoiding any jerking or swinging of the weight. Use an appropriate weight that allows you to complete the desired number of repetitions with proper form and without compromising safety. ",
                    ImageName = "BehindTheBackBarbellShrug.gif",
                },
            ];
        }

        private IEnumerable<Exercise> GetShoulderExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Military Press",
                    Explanation = "The barbell military press, also known as the standing barbell shoulder press or overhead press, is a popular strength training exercise that primarily targets the muscles of the shoulders, but also engages the triceps and upper back muscles.",
                    PerformTip = "Grasp a barbell or body bar with an overhand grip. Your hands should be wider than shoulder width. Raise the barbell so that it is just below your chin, and keep your knees slightly bent. While keeping your core muscles engaged, exhale and press your arms over your head. Hold for a brief second at the top and then slowly lower back to the starting position. You can perform this exercise with your feet parallel or with your feet staggered. When your feet are parallel there is more challenge on balance and there is also more challenge on your lower back.",
                    ImageName = "BarbellMilitaryPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Shoulder Press",
                    Explanation = "The dumbbell shoulder press, also known as the dumbbell overhead press, is an exercise that targets the muscles of the shoulders and upper body. It involves lifting a pair of dumbbells from shoulder level to an overhead position, using the shoulders and arms.The dumbbell shoulder press targets the shoulder muscles, specifically the front deltoids. ",
                    PerformTip = "Begin seated with your feet firmly on the floor. Hold the dumbbells at shoulder height with your palms facing forwards. Exhale and press the dumbbells over your head. Hold for a brief second at the top and then slowly lower to the starting position.",
                    ImageName = "DumbbellShoulderPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Seated Lateral Raise",
                    Explanation = "The seated lateral raise primarily targets the lateral deltoids (shoulder muscles). It helps to develop shoulder width and definition.",
                    PerformTip = "Sit on a bench with your back straight and dumbbells in each hand, palms facing your body. Hold the dumbbells at your sides with a slight bend in your elbows. Raise the dumbbells laterally until they reach shoulder height, keeping your arms straight or with a slight bend at the elbows. Pause at the top of the movement, then slowly lower the dumbbells back to the starting position.",
                    ImageName = "SeatedLateralRaise.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Cable Lateral Raise",
                    Explanation = "The cable lateral raise primarily targets the lateral deltoids (shoulder muscles), helping to build shoulder width and definition. Using cables provides constant tension throughout the movement.",
                    PerformTip = "Stand beside a cable machine with the handle attached to the low pulley. Grasp the handle with your hand and stand tall with your feet shoulder-width apart. Keep a slight bend in your elbow and your palm facing down. Raise your arm directly out to the side until it reaches shoulder height, maintaining a slight bend in your elbow. Pause at the top of the movement, then slowly lower the handle back to the starting position under control.",
                    ImageName = "CableLateralRaise.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Cable Rear Delt Fly",
                    Explanation = "The cable rear delt fly primarily targets the rear deltoids (posterior shoulder muscles), helping to improve shoulder stability and posture. It also engages the upper back muscles.",
                    PerformTip = "Stand facing away from the cable machine with the handle attached to the low pulley. Hold the handle with one hand and step forward slightly with the opposite foot for stability. Keep a slight bend in your elbow and your palm facing down. Pull the handle straight back and out to the side until your arm is parallel to the ground and in line with your body, focusing on squeezing your shoulder blades together. Pause at the top of the movement, then slowly return the handle to the starting position under control.",
                    ImageName = "CableRearDeltFly.gif",
                },
                // + trapezius
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Bodyweight Military Press",
                    Explanation = "The Bodyweight military press is a basic shoulder exercise that primarily targets the shoulder muscles. This is a variation of the traditional military press, but instead of using weights like dumbbells or barbells, you only use your body weight for resistance.",
                    PerformTip = "Start by standing with your feet shoulder-width apart and your arms at your sides. Raise your arms up to shoulder level, bending your elbows at a 90-degree angle, with your palms facing forward. Engage your core and squeeze your glutes to maintain stability throughout the movement. Slowly press your hands directly overhead, extending your arms fully without locking your elbows. Imagine pushing the ceiling away from you. Pause for a moment at the top, ensuring your arms are fully extended. Slowly lower your hands back down to the starting position, maintaining control and a controlled pace.",
                    ImageName = "BodyweightMilitaryPress.gif",
                },
                // + trapezius
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Rope High Cable Row",
                    Explanation = "Half kneeling high cable row is a tremendous exercise that effectively works many muscles, including the shoulder, back, wing and trapezius muscles. It also activates the trapezius muscles",
                    PerformTip = " Grasp the rope handles with an overhand grip, keeping your arms fully extended and your torso upright. Engage your core muscles to maintain a stable spine throughout the movement. Initiate the rowing motion by retracting your shoulder blades and pulling the rope towards your lower chest, keeping your elbows close to your body. Squeeze your shoulder blades together at the end of the movement to maximize muscle contraction in the upper back. Slowly return the rope to the starting position under control, allowing your arms to fully extend without locking out your elbows. Perform the exercise with a smooth and controlled motion, focusing on feeling the muscles of your upper back working throughout the entire range of motion. Avoid using momentum or excessive body movement to complete the exercise, and maintain proper posture and alignment at all times. Adjust the weight as needed to ensure challenging yet manageable resistance for the desired number of repetitions.",
                    ImageName = "RopeHighCableRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Reverse Pec Deck",
                    Explanation = "The reverse pec deck primarily targets the rear deltoids (posterior shoulder muscles) and the upper back muscles, such as the rhomboids and traps. It helps to improve shoulder stability and posture while also promoting balanced shoulder development.",
                    PerformTip = "Sit on the pec deck machine facing the backrest with your chest against the pad and your feet flat on the floor. Grasp the handles with an overhand grip, palms facing backward. Keep a slight bend in your elbows throughout the movement. Pull the handles out to the sides and back, squeezing your shoulder blades together as you do so. Pause at the back of the movement, then slowly return to the starting position with control.",
                    ImageName = "ReversePecDeck.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "One Arm Kettlebell Swing",
                    Explanation = "The one-arm kettlebell swing is a dynamic exercise that primarily targets the posterior chain, including the hamstrings, glutes, and lower back. It also engages the core muscles and shoulders.",
                    PerformTip = "Stand with your feet shoulder-width apart and a kettlebell on the ground between your legs. Squat down and grip the kettlebell handle with one hand. Keep your back flat and chest up. Swing the kettlebell back between your legs, then explosively drive your hips forward, swinging the kettlebell up to shoulder height. Keep your arm straight and core engaged throughout the movement. Control the kettlebell on the way down and immediately swing it back between your legs to begin the next rep. Repeat for the desired number of reps, then switch sides.",
                    ImageName = "OneArmKettlebellSwing.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Face Pull",
                    Explanation = "The face pull is an excellent exercise for targeting the rear deltoids, upper back, and rotator cuff muscles. It helps to improve shoulder stability, posture, and overall shoulder health.",
                    PerformTip = "Attach a rope or handles to a cable machine at chest height. Stand facing the machine with your feet shoulder-width apart and grab the handles with an overhand grip. Step back to create tension in the cable. Pull the handles towards your face, keeping your elbows high and out to the sides. Squeeze your shoulder blades together at the end of the movement. Slowly return to the starting position with control, allowing your arms to fully extend.",
                    ImageName = "FacePull.gif",
                },
            ];
        }

        private IEnumerable<Exercise> GetChestExercises()
        {

            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Bench Press",
                    Explanation = "The barbell bench press is a compound exercise that targets the chest, shoulders, and triceps. It's considered one of the best exercises for building overall upper body strength and muscle mass.",
                    PerformTip = "Lie flat on a bench with your feet planted firmly on the ground. Grip the barbell slightly wider than shoulder-width apart, with your arms fully extended and wrists stacked directly above your elbows. Lower the barbell to your chest while keeping your elbows at a 45-degree angle to your body. Press the barbell back up to the starting position, fully extending your arms and squeezing your chest muscles at the top of the movement.",
                    ImageName = "BarbellBenchPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Incline Barbell Bench Press",
                    Explanation = "The incline barbell bench press targets the upper chest muscles (clavicular head of the pectoralis major) more than the flat bench press. It helps to develop a well-rounded chest.",
                    PerformTip = "Lie on an incline bench set at around a 30-45 degree angle. Grip the barbell slightly wider than shoulder-width apart, with your arms fully extended and wrists stacked directly above your elbows. Lower the barbell to your upper chest while keeping your elbows at a 45-degree angle to your body. Press the barbell back up to the starting position, fully extending your arms and squeezing your chest muscles at the top of the movement.",
                    ImageName = "InclineBarbellBenchPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Chest Dips",
                    Explanation = "Chest dips primarily target the lower chest muscles (sternal head of the pectoralis major) along with the triceps and anterior deltoids. They are performed using parallel bars or a dip station.",
                    PerformTip = "Hold onto parallel bars or a dip station with your arms fully extended and your body straight. Lower your body by bending your elbows until your upper arms are parallel to the ground, keeping your elbows close to your sides. Push through your palms to return to the starting position, fully extending your arms and squeezing your chest muscles at the top of the movement.",
                    ImageName = "ChestDips.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "High Cable Crossover",
                    Explanation = "High cable crossover is a cable exercise that targets the chest muscles. It involves using a cable machine with the pulleys set to the highest position and crossing the arms in front of the body at the end of the movement. This move targets the pecs, specifically the lower, inner and outer areas, while also working the shoulders and triceps as secondary muscles.",
                    PerformTip = "Adjust the pulleys on a cable machine to the highest position. Stand in the middle of the cable machine with one foot forward for stability. Grasp the handles with your palms facing downward and your arms slightly bent. Keep your core engaged and chest up as you pull the handles downward and together in front of you, crossing them over at the bottom of the movement. Squeeze your chest muscles at the center and then return to the starting position in a controlled manner, allowing your arms to fully extend.",
                    ImageName = "HighCableCrossover.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Low Cable Crossover",
                    Explanation = "The low cable crossover is a chest exercise that targets the pectoralis major muscles. It provides constant tension throughout the movement, helping to develop muscle size and definition in the chest.",
                    PerformTip = "Adjust the pulleys on a cable machine to the lowest position. Stand in the middle of the cable machine with one foot forward for stability. Grasp the handles with your palms facing upward and your arms slightly bent. Keep your core engaged and chest up as you pull the handles upward and together in front of you, crossing them over at the top of the movement. Squeeze your chest muscles at the center and then return to the starting position in a controlled manner, allowing your arms to fully extend.",
                    ImageName = "LowCableCrossover.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Press",
                    Explanation = "The dumbbell press is a versatile exercise that targets the chest, shoulders, and triceps. It allows for a greater range of motion compared to the barbell bench press and can help improve muscle balance and stability.",
                    PerformTip = "Sit on a bench with back support and hold a dumbbell in each hand at shoulder height, palms facing forward. Press the dumbbells upward until your arms are fully extended, bringing them close together without touching at the top. Lower the dumbbells back down to shoulder height in a controlled manner, feeling a stretch in your chest. Repeat for the desired number of repetitions.",
                    ImageName = "DumbbellPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Push-Up",
                    Explanation = "The push-up is a classic bodyweight exercise that targets the chest, shoulders, and triceps. It can be performed anywhere with no equipment required, making it a convenient and effective exercise for building upper body strength and muscle endurance.",
                    PerformTip = "Start in a plank position with your hands shoulder-width apart and your body in a straight line from head to heels. Lower your body towards the ground by bending your elbows, keeping them close to your sides. Once your chest nearly touches the ground, push through your palms to return to the starting position. Keep your core engaged throughout the movement to maintain proper form.",
                    ImageName = "PushUp.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Cobra Push-Up",
                    Explanation = "The cobra push-up is a bodyweight exercise that primarily targets the chest, shoulders, and triceps while also engaging the core and lower back muscles. It's an advanced variation of the traditional push-up that involves a deeper range of motion.",
                    PerformTip = "Start in a prone position with your hands placed under your shoulders and your legs fully extended. Press your chest off the ground while keeping your hips and thighs on the floor, arching your back and lifting your gaze upward. Engage your chest, shoulders, and triceps as you push through your palms to extend your arms. Lower yourself back down to the starting position with control, feeling a stretch in your chest and maintaining tension in your core and lower back.",
                    ImageName = "CobraPushUp.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Assisted Chest Dip",
                    Explanation = "The assisted chest dip is a variation of the chest dip exercise that provides assistance to help perform the movement with proper form. It primarily targets the lower chest muscles (sternal head of the pectoralis major) along with the triceps and anterior deltoids.",
                    PerformTip = "Use an assisted dip machine or resistance bands to provide assistance during the exercise. Stand on the platform or step onto the resistance band, ensuring it provides enough support to assist you during the movement. Grip the handles with your palms facing inward and your arms fully extended. Lower your body by bending your elbows until your upper arms are parallel to the ground, keeping your elbows close to your sides. Push through your palms to return to the starting position, fully extending your arms and squeezing your chest muscles at the top of the movement.",
                    ImageName = "AssistedChestDip.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Decline Barbell Bench Press",
                    Explanation = "The decline barbell bench press targets the lower chest muscles (pectoralis major, sternal head) along with the triceps and anterior deltoids. By performing the exercise on a decline bench, you increase the range of motion and emphasize the lower chest muscles.",
                    PerformTip = "Lie on a decline bench with your feet securely locked in place. Grip the barbell slightly wider than shoulder-width apart, with your arms fully extended and wrists stacked directly above your elbows. Lower the barbell to your lower chest while keeping your elbows at a 45-degree angle to your body. Press the barbell back up to the starting position, fully extending your arms and squeezing your chest muscles at the top of the movement.",
                    ImageName = "DeclineBarbellBenchPress.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetBackExercises()
        {
            return
            [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Overhand Grip Pull-ups",
                    Explanation = "Overhand grip pull-ups, also known as chin-ups, are a challenging bodyweight exercise that primarily targets the muscles of the back, including the latissimus dorsi, rhomboids, and biceps. They also engage the shoulders, arms, and core muscles.",
                    PerformTip = "Hang from a pull-up bar with your hands slightly wider than shoulder-width apart and your palms facing away from you. Keep your arms fully extended and engage your core muscles. Pull yourself up by bending your elbows and driving your shoulder blades down and back. Aim to bring your chest towards the bar while keeping your body in a straight line. Lower yourself back down to the starting position in a controlled manner, fully extending your arms.",
                    ImageName = "OverhandGripPullups.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Row",
                    Explanation = "The barbell row is a compound exercise that targets the muscles of the upper back, including the latissimus dorsi, rhomboids, and traps, as well as the biceps and forearms.",
                    PerformTip = "Stand with your feet shoulder-width apart and grasp a barbell with an overhand grip, hands slightly wider than shoulder-width apart. Bend your knees slightly and hinge at your hips to bring your torso forward to about a 45-degree angle. Keep your back straight and core engaged. Pull the barbell towards your lower chest by retracting your shoulder blades and bending your elbows. Squeeze your back muscles at the top of the movement, then lower the barbell back down to the starting position with control.",
                    ImageName = "BarbellRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Row",
                    Explanation = "The dumbbell row is a unilateral exercise that targets the muscles of the upper back, including the latissimus dorsi, rhomboids, and traps, as well as the biceps and forearms.",
                    PerformTip = "Hold a dumbbell in one hand and place the opposite knee and hand on a bench for support. Keep your back flat and core engaged. Pull the dumbbell towards your hip by retracting your shoulder blade and bending your elbow. Squeeze your back muscles at the top of the movement, then lower the dumbbell back down to the starting position with control.",
                    ImageName = "DumbbellRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Seated Row Machine",
                    Explanation = "The seated row machine is a compound exercise that targets the muscles of the upper back, including the latissimus dorsi, rhomboids, and traps, as well as the biceps and forearms.",
                    PerformTip = "Sit on the machine with your feet flat on the footrests and grasp the handles with an overhand grip. Keep your back straight and core engaged. Pull the handles towards your lower chest by retracting your shoulder blades and bending your elbows. Squeeze your back muscles at the end of the movement, then slowly return the handles to the starting position with control.",
                    ImageName = "SeatedRowMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Lat Pulldowns",
                    Explanation = "Lat pulldowns are a compound exercise that primarily targets the latissimus dorsi muscles of the back, as well as the biceps and forearms.",
                    PerformTip = "Sit at a lat pulldown machine with your knees securely under the pads and grasp the bar with an overhand grip wider than shoulder-width apart. Keep your back straight and chest up. Pull the bar down towards your chest by engaging your lats and bending your elbows. Squeeze your back muscles at the bottom of the movement, then slowly return the bar to the starting position with control.",
                    ImageName = "LatPulldowns.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Close Grip Cable Row",
                    Explanation = "The close grip cable row is a compound exercise that primarily targets the middle and lower trapezius muscles, as well as the rhomboids, rear deltoids, and biceps.",
                    PerformTip = "Sit at a cable row machine with your feet flat on the footrests and grasp the handles with a close, neutral grip. Keep your back straight and chest up. Pull the handles towards your lower chest by retracting your shoulder blades and bending your elbows. Squeeze your back muscles at the end of the movement, then slowly return the handles to the starting position with control.",
                    ImageName = "CloseGripCableRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Deadlift",
                    Explanation = "The deadlift is a compound exercise that targets multiple muscle groups, including the lower back, glutes, hamstrings, and forearms.",
                    PerformTip = "Stand with your feet shoulder-width apart and a barbell on the floor in front of you. Bend at your hips and knees to grip the barbell with an overhand grip, hands slightly wider than shoulder-width apart. Keep your back flat, chest up, and core engaged. Push through your heels to lift the barbell off the floor, extending your hips and knees until you are standing upright. Keep the barbell close to your body throughout the movement. Lower the barbell back down to the floor with control, maintaining a flat back and keeping your core engaged.",
                    ImageName = "Deadlift.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Back Extensions",
                    Explanation = "Back extensions target the lower back muscles, primarily the erector spinae, and also engage the glutes and hamstrings.",
                    PerformTip = "Lie face down on a back extension bench with your hips resting on the pad and your feet secured under the footrests. Cross your arms over your chest or place your hands behind your head. Keep your back straight and core engaged as you lift your torso up until it is in line with your hips. Lower your torso back down to the starting position with control, maintaining tension in your lower back muscles throughout the movement.",
                    ImageName = "BackExtensions.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Push-Up to Renegade Row",
                    Explanation = "The push-up to renegade row is a compound exercise that targets the chest, shoulders, back, and core muscles.",
                    PerformTip = "Start in a plank position with a dumbbell in each hand. Perform a push-up by bending your elbows and lowering your chest towards the ground while keeping your core engaged and back flat. Push back up to the starting position. Row one dumbbell up to your side while stabilizing your body with the other hand and keeping your hips square to the ground. Lower the dumbbell back down to the ground, then repeat the row on the other side. Continue alternating sides for the desired number of repetitions.",
                    ImageName = "PushUpRenegadeRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Band Seated Row",
                    Explanation = "The band seated row is a resistance band exercise that targets the muscles of the upper back, including the latissimus dorsi, rhomboids, and traps, as well as the biceps and forearms.",
                    PerformTip = "Sit on the floor with your legs extended in front of you and a resistance band looped around your feet. Hold the ends of the band with an overhand grip. Keep your back straight and chest up. Pull the band towards your lower chest by retracting your shoulder blades and bending your elbows. Squeeze your back muscles at the end of the movement, then slowly return the band to the starting position with control.",
                    ImageName = "BandSeatedRow.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetBicepsExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Preacher Curl",
                    Explanation = "The preacher curl is a bicep isolation exercise that targets the biceps brachii muscle, specifically the long head. It's performed using a preacher bench, which helps to stabilize the upper arms and isolate the biceps.",
                    PerformTip = "Sit on a preacher bench with your upper arms resting on the angled pad and your chest against the pad. Grasp an EZ bar with an underhand grip, hands slightly wider than shoulder-width apart. Allow your arms to fully extend and hang perpendicular to the floor. Curl the barbell towards your shoulders by flexing your elbows. Squeeze your biceps at the top of the movement, then lower the barbell back down to the starting position with control.",
                    ImageName = "PreacherCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hammer Curl",
                    Explanation = "The hammer curl is a bicep exercise that targets the brachialis muscle, located underneath the biceps, as well as the brachioradialis muscle in the forearm. It's performed with a neutral grip, palms facing each other.",
                    PerformTip = "Stand with your feet shoulder-width apart and hold a pair of dumbbells by your sides with a neutral grip (palms facing each other). Keep your back straight and chest up. Curl the dumbbells towards your shoulders by flexing your elbows. Keep your wrists straight throughout the movement. Squeeze your biceps at the top of the movement, then lower the dumbbells back down to the starting position with control.",
                    ImageName = "HammerCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Chin Up",
                    Explanation = "Chin-ups are a compound exercise that primarily targets the biceps, along with the back and shoulders. They are performed with an underhand grip, palms facing towards you.",
                    PerformTip = "Hang from a pull-up bar with an underhand grip, hands slightly closer than shoulder-width apart. Keep your arms fully extended and engage your core muscles. Pull yourself up by bending your elbows and driving your shoulder blades down and back. Aim to bring your chin above the bar while keeping your body in a straight line. Lower yourself back down to the starting position in a controlled manner, fully extending your arms.",
                    ImageName = "ChinUp.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Concentration Curl",
                    Explanation = "The concentration curl is a bicep isolation exercise that targets the biceps brachii muscle. It's performed seated with the elbow braced against the inner thigh, allowing for a full range of motion and maximum contraction.",
                    PerformTip = "Sit on a bench with your legs spread apart and hold a dumbbell in one hand. Rest the back of your upper arm against the inner thigh of the same side. Allow the dumbbell to hang straight down towards the floor. Curl the dumbbell towards your shoulder by flexing your elbow. Squeeze your bicep at the top of the movement, then lower the dumbbell back down to the starting position with control.",
                    ImageName = "ConcentrationCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "EZ Bar Curl",
                    Explanation = "The EZ bar curl is a bicep exercise that targets the biceps brachii muscle. It's performed with an EZ curl bar, which has a zigzag shape that allows for a more comfortable grip and reduces strain on the wrists.",
                    PerformTip = "Stand with your feet shoulder-width apart and grasp an EZ bar with an underhand grip, hands slightly wider than shoulder-width apart. Keep your back straight and chest up. Curl the barbell towards your shoulders by flexing your elbows. Squeeze your biceps at the top of the movement, then lower the barbell back down to the starting position with control.",
                    ImageName = "EZBarCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Incline Dumbbell Curl",
                    Explanation = "The incline dumbbell curl is a bicep exercise that targets the biceps brachii muscle. It's performed on an incline bench, which helps to isolate the biceps and prevent swinging.",
                    PerformTip = "Set an incline bench to a 45-degree angle and sit back with your back against the bench. Hold a dumbbell in each hand with an underhand grip, arms fully extended and hanging down towards the floor. Curl the dumbbells towards your shoulders by flexing your elbows. Keep your back against the bench and avoid using momentum to swing the weights. Squeeze your biceps at the top of the movement, then lower the dumbbells back down to the starting position with control.",
                    ImageName = "InclineDumbbellCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Crucifix Curl",
                    Explanation = "The crucifix curl is a bicep exercise that targets the biceps brachii muscle. It's performed with a barbell or dumbbells, with the arms abducted to the sides, resembling a crucifix position.",
                    PerformTip = "Stand with your feet shoulder-width apart and hold a barbell or dumbbells with an overhand grip, arms extended out to the sides at shoulder height. Keep your back straight and chest up. Curl the barbell or dumbbells towards your shoulders by flexing your elbows. Keep your arms abducted to the sides throughout the movement. Squeeze your biceps at the top of the movement, then lower the barbell or dumbbells back down to the starting position with control.",
                    ImageName = "CrucifixCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Resistance Band Curl",
                    Explanation = "The resistance band curl is a bicep exercise that targets the biceps brachii muscle. It's performed using a resistance band, which provides constant tension throughout the movement.",
                    PerformTip = "Stand on a resistance band with your feet shoulder-width apart and hold the handles or ends with an underhand grip, hands slightly wider than shoulder-width apart. Keep your back straight and chest up. Curl the handles or ends towards your shoulders by flexing your elbows. Squeeze your biceps at the top of the movement, then lower the handles or ends back down to the starting position with control.",
                    ImageName = "ResistanceBandCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Zottman Curl",
                    Explanation = "The Zottman curl is a bicep exercise that targets the biceps brachii muscle, as well as the brachialis and brachioradialis muscles. It's performed with a combination of supination and pronation grips.",
                    PerformTip = "Stand with your feet shoulder-width apart and hold a pair of dumbbells with an underhand grip (palms facing up). Curl the dumbbells towards your shoulders by flexing your elbows. At the top of the movement, rotate your wrists so that your palms are facing down (pronation grip). Lower the dumbbells back down to the starting position with control. At the bottom of the movement, rotate your wrists back to the underhand grip (supination grip) before curling the dumbbells again.",
                    ImageName = "ZottmanCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "EZ Bar Preacher Curl",
                    Explanation = "The EZ bar preacher curl is a variation of the preacher curl exercise that targets the biceps brachii muscle. It's performed using an EZ curl bar, which has a zigzag shape that allows for a more comfortable grip and reduces strain on the wrists.",
                    PerformTip = "Sit on a preacher bench with your upper arms resting on the angled pad and your chest against the pad. Grasp an EZ bar with an underhand grip, hands slightly wider than shoulder-width apart. Allow your arms to fully extend and hang perpendicular to the floor. Curl the barbell towards your shoulders by flexing your elbows. Squeeze your biceps at the top of the movement, then lower the barbell back down to the starting position with control.",
                    ImageName = "EZBarPreacherCurl.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetTricepsExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Triceps Push-down",
                    Explanation = "The triceps push-down is an isolation exercise that targets the triceps brachii muscle. It's performed using a cable machine with a straight or angled bar attachment.",
                    PerformTip = "Stand in front of a cable machine with your feet shoulder-width apart and grasp the bar with an overhand grip, hands shoulder-width apart. Keep your elbows close to your sides and your upper arms stationary. Push the bar downwards by straightening your elbows until your arms are fully extended. Squeeze your triceps at the bottom of the movement, then slowly return the bar to the starting position with control.",
                    ImageName = "TricepsPushdown.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Cable Rope Overhead Triceps Extension",
                    Explanation = "The cable rope overhead triceps extension is an isolation exercise that targets the long head of the triceps brachii muscle. It's performed using a cable machine with a rope attachment.",
                    PerformTip = "Stand facing away from the cable machine with your feet shoulder-width apart and hold the rope attachment with an overhand grip, hands close together. Bring the rope overhead with your elbows bent and close to your head. Extend your elbows to lift the rope upwards until your arms are fully extended. Squeeze your triceps at the top of the movement, then slowly return the rope to the starting position with control.",
                    ImageName = "CableRopeOverheadTricepsExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Triceps Dips",
                    Explanation = "Triceps dips are a compound exercise that targets the triceps brachii muscle, as well as the chest and shoulders. They are performed using parallel bars or a dip station.",
                    PerformTip = "Stand between parallel bars or a dip station with your arms fully extended and your hands gripping the bars. Keep your chest up and shoulders back. Lower your body by bending your elbows until your upper arms are parallel to the ground. Keep your elbows close to your sides. Push yourself back up to the starting position by straightening your elbows and squeezing your triceps.",
                    ImageName = "TricepsDips.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Seated Dumbbell Triceps Extension",
                    Explanation = "The seated dumbbell triceps extension is an isolation exercise that targets the triceps brachii muscle. It's performed seated on a bench with a dumbbell in one hand.",
                    PerformTip = "Sit on a bench with back support and hold a dumbbell with both hands overhead, arms fully extended. Lower the dumbbell behind your head by bending your elbows, keeping your upper arms close to your head. Extend your elbows to lift the dumbbell back to the starting position. Squeeze your triceps at the top of the movement, then lower the dumbbell back down with control.",
                    ImageName = "SeatedDumbbellTricepsExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "High Pulley Overhead Tricep Extension",
                    Explanation = "The high pulley overhead tricep extension is an isolation exercise that targets the triceps brachii muscle. It's performed using a cable machine with a high pulley attachment.",
                    PerformTip = "Stand facing away from the cable machine with your feet shoulder-width apart and grasp the rope attachment with an overhand grip, hands close together. Bring the rope overhead with your elbows bent and close to your head. Extend your elbows to lift the rope upwards until your arms are fully extended. Squeeze your triceps at the top of the movement, then slowly return the rope to the starting position with control.",
                    ImageName = "HighPulleyOverheadTricepExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Rope Pushdown",
                    Explanation = "The rope pushdown is an isolation exercise that targets the triceps brachii muscle. It's performed using a cable machine with a rope attachment.",
                    PerformTip = "Stand in front of a cable machine with your feet shoulder-width apart and grasp the rope attachment with an overhand grip, hands shoulder-width apart. Keep your elbows close to your sides and your upper arms stationary. Push the rope downwards by straightening your elbows until your arms are fully extended. Squeeze your triceps at the bottom of the movement, then slowly return the rope to the starting position with control.",
                    ImageName = "RopePushdown.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Skull Crusher",
                    Explanation = "The dumbbell skull crusher is an isolation exercise that targets the triceps brachii muscle. It's performed lying on a bench with dumbbells in each hand.",
                    PerformTip = "Lie on a flat bench with a dumbbell in each hand, palms facing each other. Extend your arms straight up towards the ceiling, keeping your elbows in line with your shoulders. Bend your elbows to lower the dumbbells towards your temples, keeping your upper arms stationary. Lower the dumbbells until they are close to your head, then extend your elbows to lift the dumbbells back to the starting position. Squeeze your triceps at the top of the movement, then repeat.",
                    ImageName = "DumbbellSkullCrusher.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Close Grip Bench Press",
                    Explanation = "The close grip bench press is a compound exercise that targets the triceps brachii muscle, as well as the chest and shoulders. It's performed similar to the traditional bench press, but with a narrower grip.",
                    PerformTip = "Lie on a flat bench with your feet flat on the floor and grasp the barbell with a narrow grip, hands shoulder-width apart or closer. Lower the barbell towards your chest by bending your elbows, keeping your upper arms close to your body. Press the barbell back up to the starting position by extending your elbows. Squeeze your triceps at the top of the movement, then repeat.",
                    ImageName = "CloseGripBenchPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Banded Overhead Triceps Extension",
                    Explanation = "The banded overhead triceps extension is an isolation exercise that targets the triceps brachii muscle. It's performed using a resistance band.",
                    PerformTip = "Stand on a resistance band with your feet shoulder-width apart and hold one end of the band with both hands overhead. Keep your elbows close to your head. Extend your elbows to lift the band upwards until your arms are fully extended. Squeeze your triceps at the top of the movement, then slowly return the band to the starting position with control.",
                    ImageName = "BandedOverheadTricepsExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Bench Dips on Floor",
                    Explanation = "Bench dips on the floor are a compound exercise that targets the triceps brachii muscle, as well as the chest and shoulders. They are performed using a bench or elevated surface.",
                    PerformTip = "Sit on the floor with your legs extended in front of you and your hands placed behind you on a bench or elevated surface, fingers pointing towards your body. Lift your hips off the floor and walk your feet forward until your knees are bent at a 90-degree angle. Lower your body by bending your elbows until your upper arms are parallel to the floor. Push yourself back up to the starting position by straightening your elbows and squeezing your triceps.",
                    ImageName = "BenchDipsOnFloor.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetForearmExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Reverse Grip EZ-Bar Curl",
                    Explanation = "The reverse grip EZ-bar curl is a variation of the bicep curl that targets the brachioradialis muscle in the forearms along with the biceps brachii.",
                    PerformTip = "Stand upright with your feet shoulder-width apart and hold an EZ-bar with an underhand grip, hands shoulder-width apart. Allow your arms to fully extend and hang perpendicular to the floor. Curl the EZ-bar towards your shoulders by flexing your elbows. Keep your upper arms close to your body and focus on contracting the muscles in your forearms. Lower the EZ-bar back to the starting position with control.",
                    ImageName = "ReverseGripEZBarCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Reverse Curl",
                    Explanation = "The dumbbell reverse curl is an exercise that primarily targets the brachioradialis muscle in the forearms.",
                    PerformTip = "Stand upright with your feet shoulder-width apart and hold a pair of dumbbells with an overhand grip, palms facing downwards. Allow your arms to fully extend and hang perpendicular to the floor. Curl the dumbbells towards your shoulders by flexing your elbows. Keep your upper arms close to your body and focus on contracting the muscles in your forearms. Lower the dumbbells back to the starting position with control.",
                    ImageName = "DumbbellReverseCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Reverse Wrist Curl Over a Bench",
                    Explanation = "The barbell reverse wrist curl over a bench is an isolation exercise that targets the forearm extensors.",
                    PerformTip = "Sit on a bench with your forearms resting on the bench and your wrists hanging over the edge, palms facing downwards. Hold a barbell with an overhand grip, hands shoulder-width apart. Allow the barbell to roll down towards your fingertips by flexing your wrists. Curl the barbell back up towards your forearms by extending your wrists. Focus on contracting the muscles in your forearms throughout the movement. Lower the barbell back down to the starting position with control.",
                    ImageName = "BarbellReverseWristCurlOverABench.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Finger Curl",
                    Explanation = "The dumbbell finger curl is an isolation exercise that targets the forearm flexors and grip strength.",
                    PerformTip = "Sit on a bench with your feet flat on the floor and hold a dumbbell in one hand with an overhand grip, palm facing upwards. Rest your forearm on your thigh, allowing your hand and the dumbbell to hang over the edge of your knee. Allow the dumbbell to roll down towards your fingertips by extending your fingers. Curl the dumbbell back up towards your palm by flexing your fingers. Focus on contracting the muscles in your forearm throughout the movement. Lower the dumbbell back down to the starting position with control.",
                    ImageName = "DumbbellFingerCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Wrist Curl",
                    Explanation = "The dumbbell wrist curl is an isolation exercise that targets the forearm flexors.",
                    PerformTip = "Sit on a bench with your forearms resting on your thighs and your wrists hanging over the edge, palms facing upwards. Hold a dumbbell in one hand with an overhand grip. Allow the dumbbell to roll down towards your fingertips by flexing your wrists. Curl the dumbbell back up towards your forearms by extending your wrists. Focus on contracting the muscles in your forearms throughout the movement. Lower the dumbbell back down to the starting position with control.",
                    ImageName = "DumbbellWristCurl.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetAbsExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Decline Sit-up",
                    Explanation = "The decline sit-up is a variation of the sit-up exercise that targets the abdominal muscles. It's performed on a decline bench, which increases the range of motion and provides additional resistance.",
                    PerformTip = "Lie on a decline bench with your feet secured and your hands crossed over your chest or placed behind your head. Engage your core muscles to lift your torso towards your thighs, keeping your back straight. Exhale as you sit up and inhale as you lower back down to the starting position. Focus on controlled movements and avoid using momentum to lift your body.",
                    ImageName = "DeclineSitUp.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Incline Leg Hip Raise",
                    Explanation = "The incline leg hip raise is an exercise that targets the lower abdominal muscles. It's performed on an incline bench, which increases the range of motion and provides additional resistance.",
                    PerformTip = "Lie on an incline bench with your head at the top and your hands gripping the sides for support. Extend your legs straight up towards the ceiling, keeping them together. Engage your core muscles to lift your hips off the bench towards the ceiling. Lower your hips back down to the starting position with control. Focus on maintaining stability and avoid arching your back.",
                    ImageName = "InclineLegHipRaise.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Captains Chair Leg Raise",
                    Explanation = "The captains chair leg raise is an exercise that targets the lower abdominal muscles. It's performed using a captains chair apparatus, which consists of padded armrests and a backrest.",
                    PerformTip = "Stand on the captains chair platform and grip the handles to support your upper body. Keep your back against the backrest and your arms straight. Lift your knees towards your chest by flexing your hips and bending your knees. Lower your legs back down to the starting position with control. Avoid swinging your legs or using momentum to lift them.",
                    ImageName = "CaptainsChairLegRaise.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Plank",
                    Explanation = "The plank is an isometric exercise that targets the core muscles, including the rectus abdominis, transverse abdominis, and obliques.",
                    PerformTip = "Start in a push-up position with your hands shoulder-width apart and your elbows bent at 90 degrees, resting on your forearms. Keep your body in a straight line from your head to your heels, engaging your core muscles to maintain stability. Hold this position for the desired duration, keeping your back flat and avoiding sagging or arching.",
                    ImageName = "Plank.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Cross Crunch",
                    Explanation = "The cross crunch is an exercise that targets the oblique muscles. It's performed by combining a crunch motion with a twisting motion.",
                    PerformTip = "Lie on your back with your knees bent and your feet flat on the floor. Place your hands behind your head or across your chest. Crunch upwards, bringing your right elbow towards your left knee while simultaneously twisting your torso. Lower your upper body back down to the starting position and repeat on the other side. Alternate sides for the desired number of repetitions.",
                    ImageName = "CrossCrunch.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Leg Scissors",
                    Explanation = "Leg scissors is an exercise that targets the lower abdominal muscles and hip flexors. It's performed by alternating the movement of the legs in a scissor-like motion.",
                    PerformTip = "Lie on your back with your hands under your glutes for support and your legs extended straight out. Lift your legs a few inches off the ground, keeping them straight. Open your legs wide and then cross one leg over the other, as if you were closing a pair of scissors. Continue alternating the movement of your legs in a controlled manner, keeping your core engaged throughout.",
                    ImageName = "LegScissors.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Seated Twist Machine",
                    Explanation = "The seated twist machine is an exercise machine that targets the oblique muscles. It's performed by rotating the torso against resistance provided by the machine.",
                    PerformTip = "Sit on the machine with your back against the pad and grasp the handles with both hands. Keep your feet flat on the floor and your knees bent. Rotate your torso to one side as far as comfortably possible, then return to the starting position and repeat on the other side. Control the movement and focus on engaging your oblique muscles.",
                    ImageName = "SeatedTwistMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Swiss Ball Rollout",
                    Explanation = "The Swiss ball rollout is an exercise that targets the core muscles, including the rectus abdominis and transverse abdominis. It's performed using a Swiss ball to increase instability and challenge the core muscles.",
                    PerformTip = "Kneel on the floor with a Swiss ball in front of you and place your hands on top of the ball. Roll the ball forward by extending your arms and lowering your torso towards the floor. Keep your core engaged and your back flat throughout the movement. Once you feel a stretch in your abs, reverse the movement by pulling the ball back towards your knees. Control the movement and avoid arching your back.",
                    ImageName = "SwissBallRollout.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Stability Ball V-Up",
                    Explanation = "The stability ball V-up is an exercise that targets the rectus abdominis and hip flexors. It's performed using a stability ball to increase instability and engage the core muscles.",
                    PerformTip = "Lie on your back with your legs extended and your arms extended overhead, holding a stability ball between your hands and feet. Keep your lower back pressed into the floor and your core engaged. Simultaneously lift your legs and arms towards each other, forming a V-shape with your body. Pause at the top of the movement, then lower your legs and arms back down to the starting position with control. Focus on using your core muscles to lift and lower your body.",
                    ImageName = "StabilityBallVUp.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hanging Side Knee Raises",
                    Explanation = "Hanging side knee raises are an advanced core exercise that targets the oblique muscles. They're performed hanging from a pull-up bar, adding challenge and intensity to the exercise.",
                    PerformTip = "Hang from a pull-up bar with an overhand grip, hands slightly wider than shoulder-width apart. Keep your body straight and your legs together. Engage your oblique muscles to lift your knees towards your left shoulder, twisting your torso to the side. Lower your legs back down to the starting position and repeat on the other side. Alternate sides for the desired number of repetitions.",
                    ImageName = "HangingSideKneeRaises.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetLegsExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Squat",
                    Explanation = "The barbell squat is a compound exercise that targets multiple lower body muscles, including the quadriceps, hamstrings, glutes, and lower back.",
                    PerformTip = "Stand with your feet shoulder-width apart and the barbell resting on your upper traps. Keep your chest up, core engaged, and your gaze forward. Bend your knees and lower your body down as if sitting back into a chair, keeping your back straight. Lower until your thighs are parallel to the ground, then press through your heels to return to the starting position. Ensure your knees track in line with your toes throughout the movement.",
                    ImageName = "BarbellSquat.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Leg Press",
                    Explanation = "The leg press is a resistance training exercise that targets the quadriceps, hamstrings, and glutes. It's performed using a leg press machine.",
                    PerformTip = "Sit on the leg press machine with your back flat against the pad and your feet shoulder-width apart on the footplate. Push through your heels to extend your legs and lift the weight. Lower the weight back down with control, allowing your knees to bend to approximately 90 degrees. Keep your back flat against the pad throughout the movement and avoid locking out your knees at the top of the movement.",
                    ImageName = "LegPress.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hack Squats Machine",
                    Explanation = "The hack squats machine is a resistance training exercise that targets the quadriceps, hamstrings, and glutes. It's performed using a hack squats machine, which allows for a more controlled movement compared to free weights.",
                    PerformTip = "Position yourself on the hack squats machine with your shoulders against the pads and your feet shoulder-width apart on the platform. Grasp the handles for stability and release the safeties. Lower your body by bending your knees, keeping your back straight and your chest up. Lower until your thighs are parallel to the ground, then press through your heels to return to the starting position.",
                    ImageName = "HackSquatsMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Leg Extension",
                    Explanation = "The leg extension is an isolation exercise that primarily targets the quadriceps. It's performed using a leg extension machine.",
                    PerformTip = "Sit on the leg extension machine with your back against the pad and your feet hooked under the footpads. Grasp the handles for stability and extend your legs fully, lifting the weight. Hold for a moment at the top of the movement, then lower the weight back down with control. Keep your back flat against the pad throughout the movement and avoid using momentum.",
                    ImageName = "LegExtension.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Seated Leg Curl",
                    Explanation = "The seated leg curl is an isolation exercise that primarily targets the hamstrings. It's performed using a leg curl machine.",
                    PerformTip = "Sit on the leg curl machine with your back flat against the pad and your feet hooked under the footpad. Grasp the handles for stability and curl your legs towards your glutes, lifting the weight. Hold for a moment at the top of the movement, then lower the weight back down with control. Keep your back flat against the pad throughout the movement and avoid using momentum.",
                    ImageName = "SeatedLegCurl.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hip Adduction Machine",
                    Explanation = "The hip adduction machine is an isolation exercise that targets the inner thigh muscles. It's performed using a hip adduction machine.",
                    PerformTip = "Sit on the hip adduction machine with your back against the pad and your knees bent. Place your feet against the pads provided and release the safeties. Squeeze your legs together to bring the pads towards each other, engaging your inner thigh muscles. Hold for a moment at the top of the movement, then release the tension and return to the starting position with control.",
                    ImageName = "HipAdductionMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hip Abduction Machine",
                    Explanation = "The hip abduction machine is an isolation exercise that targets the outer thigh muscles. It's performed using a hip abduction machine.",
                    PerformTip = "Sit on the hip abduction machine with your back against the pad and your knees bent. Place your outer thighs against the pads provided and release the safeties. Push your legs outwards to move the pads away from each other, engaging your outer thigh muscles. Hold for a moment at the top of the movement, then release the tension and return to the starting position with control.",
                    ImageName = "HipAbductionMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "The Box Jump",
                    Explanation = "The box jump is a plyometric exercise that targets the lower body muscles, including the quadriceps, hamstrings, glutes, and calves. It also improves explosive power and coordination.",
                    PerformTip = "Stand in front of a sturdy box or platform with your feet shoulder-width apart. Bend your knees and jump explosively onto the box, using your arms to generate momentum. Land softly with both feet on the box, ensuring your knees are bent to absorb the impact. Step down from the box and repeat for the desired number of repetitions.",
                    ImageName = "BoxJump.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Jump Squats",
                    Explanation = "Jump squats are a plyometric exercise that targets the lower body muscles, including the quadriceps, hamstrings, glutes, and calves. They also improve explosive power and cardiovascular endurance.",
                    PerformTip = "Stand with your feet shoulder-width apart and your arms by your sides. Lower your body into a squat position by bending your knees and pushing your hips back, keeping your chest up and your back straight. Explosively jump upwards, extending your legs fully and reaching your arms overhead. Land softly with bent knees to absorb the impact, immediately transitioning into the next squat jump. Repeat for the desired number of repetitions, focusing on maintaining proper form and landing softly with each jump.",
                    ImageName = "JumpSquats.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Static Lunge",
                    Explanation = "The static lunge is a lower body exercise that targets the quadriceps, hamstrings, glutes, and calves. It's performed by stepping forward into a lunge position and then returning to the starting position.",
                    PerformTip = "Stand with your feet hip-width apart and your hands on your hips. Take a large step forward with your right foot and lower your body until both knees are bent at a 90-degree angle, with your right knee aligned with your ankle and your left knee hovering just above the ground. Push through your right heel to return to the starting position. Repeat on the other side, alternating legs for the desired number of repetitions.",
                    ImageName = "StaticLunge.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetCalvesExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Leg Press Calf Raise",
                    Explanation = "The leg press calf raise is an isolation exercise that targets the calf muscles (gastrocnemius and soleus). It's performed using a leg press machine.",
                    PerformTip = "Sit on the leg press machine and position your feet shoulder-width apart on the footplate, allowing your heels to hang off the edge. Release the safeties and extend your ankles, lifting the weight by pressing through the balls of your feet. Lower the weight back down with control, allowing your heels to drop below the level of the footplate to achieve a full stretch in your calves. Repeat for the desired number of repetitions.",
                    ImageName = "LegPressCalfRaise.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Hack Squat Calf Raise",
                    Explanation = "The hack squat calf raise is an isolation exercise that targets the calf muscles (gastrocnemius and soleus). It's performed using a hack squat machine.",
                    PerformTip = "Position yourself on the hack squat machine with your shoulders against the pads and your feet shoulder-width apart on the platform. Release the safeties and lower your heels as far as possible towards the ground, allowing your calves to stretch fully. Press through the balls of your feet to lift the weight, extending your ankles and raising your heels as high as possible. Hold the top position for a moment, then lower the weight back down with control. Repeat for the desired number of repetitions.",
                    ImageName = "HackSquatCalfRaise.gif",
                }
            ];
        }

        private IEnumerable<Exercise> GetFullBodyExercises()
        {
            return [
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Battle Rope",
                    Explanation = "The battle rope exercise is a dynamic and intense full-body workout that primarily targets the arms, shoulders, and core muscles. It also improves cardiovascular fitness and coordination.",
                    PerformTip = "Anchor the battle rope securely to a stable structure. Stand with your feet shoulder-width apart, knees slightly bent, and hold one end of the rope in each hand. Start swinging the ropes up and down in an alternating pattern, creating waves. Keep your core engaged and maintain a slight bend in your knees to stabilize your body. Aim to create as large and consistent waves as possible. You can vary the intensity and pattern of the waves by adjusting the speed, amplitude, and direction of your arm movements.",
                    ImageName = "BattleRope.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Barbell Bent Over Row",
                    Explanation = "The barbell bent over row is a compound exercise that targets the upper back muscles, including the latissimus dorsi, rhomboids, and traps. It also engages the biceps and forearms as secondary muscles.",
                    PerformTip = "Stand with your feet hip-width apart and hold a barbell with an overhand grip, hands slightly wider than shoulder-width apart. Hinge at your hips to bend forward until your torso is roughly parallel to the ground, keeping your back flat and chest up. Allow the barbell to hang directly below your shoulders with your arms fully extended. Pull the barbell towards your lower chest by driving your elbows back and squeezing your shoulder blades together. Lower the barbell back down with control to complete one repetition. Keep your core engaged and avoid using momentum to lift the weight.",
                    ImageName = "BarbellBentOverRow.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Rowing Machine",
                    Explanation = "The rowing machine, also known as the ergometer or rower, is a cardio and strength training exercise that targets multiple muscle groups including the back, arms, and legs. It simulates the action of rowing a boat and provides a low-impact, full-body workout.",
                    PerformTip = "Sit on the rowing machine with your feet securely strapped into the footrests and grasp the handle with an overhand grip. Extend your legs fully, then lean back slightly while keeping your back straight. Pull the handle towards your lower chest, driving your elbows back and squeezing your shoulder blades together. Extend your arms forward to return to the starting position. Continue rowing in a smooth, controlled motion, focusing on engaging your back muscles throughout the movement.",
                    ImageName = "RowingMachine.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Kettlebell Swing",
                    Explanation = "The kettlebell swing is a dynamic exercise that targets the posterior chain muscles, including the glutes, hamstrings, and lower back. It also improves power, explosiveness, and cardiovascular fitness.",
                    PerformTip = "Stand with your feet shoulder-width apart and hold a kettlebell with both hands between your legs. Hinge at your hips and slightly bend your knees, keeping your back flat and chest up. Swing the kettlebell back between your legs, then explosively drive your hips forward, swinging the kettlebell up to chest level. Allow the momentum to swing the kettlebell back down between your legs, then immediately hinge at your hips to initiate the next rep. Focus on using your hips to power the movement rather than relying on your arms.",
                    ImageName = "KettlebellSwing.gif",
                },
                new Exercise
                {
                    Id = StartingIndex++,
                    Name = "Dumbbell Sumo Deadlift",
                    Explanation = "The dumbbell sumo deadlift is a compound exercise that primarily targets the glutes, hamstrings, and lower back. It's performed with a wide stance to emphasize the inner thigh muscles (adductors) and minimize stress on the lower back.",
                    PerformTip = "Stand with your feet wider than shoulder-width apart and toes pointed slightly outward. Hold a dumbbell in each hand between your legs, with your palms facing inward. Hinge at your hips and bend your knees to lower the dumbbells towards the ground while keeping your back flat and chest up. Drive through your heels to straighten your legs and lift the dumbbells back up to the starting position. Squeeze your glutes at the top of the movement, then lower the dumbbells back down with control.",
                    ImageName = "DumbbellSumoDeadlift.gif",
                },
            ];
        }
    }
}
