# FitnessPlanner 💪

A comprehensive fitness planning application that provides personalized workout recommendations using advanced machine learning algorithms. Built with a modern tech stack featuring .NET 8 backend and React frontend.

## 🚀 Overview

FitnessPlanner is a full-stack web application designed to help users create, manage, and discover workout plans tailored to their fitness goals, skill levels, and body metrics. The application uses a sophisticated cosine similarity algorithm to recommend workout plans based on user profiles and preferences.

## 🛠️ Technologies Used

### Backend (.NET Ecosystem)
- **Framework**: .NET 8 (LTS)
- **Web API**: ASP.NET Core Web API with Swagger/OpenAPI documentation
- **Database**: PostgreSQL with Entity Framework Core 8
- **Authentication**: ASP.NET Core Identity with JWT Bearer tokens
- **File Storage**: Azure Blob Storage for exercise images and media
- **Architecture Patterns**: Clean Architecture, Repository Pattern, Dependency Injection
- **Libraries**:
  - `Ardalis.Result` - Result pattern implementation
  - `Microsoft.AspNetCore.Authentication.JwtBearer` - JWT authentication
  - `Npgsql.EntityFrameworkCore.PostgreSQL` - PostgreSQL provider
  - `Azure.Storage.Blobs` - Azure storage integration

### Frontend (React Ecosystem)
- **Framework**: React 18 with modern hooks and functional components
- **Build Tool**: Vite for fast development and optimized production builds
- **Routing**: React Router DOM v6 for client-side navigation
- **Styling**: TailwindCSS with custom design system
- **Animations**: Framer Motion for smooth UI animations
- **Form Handling**: React Hook Form for efficient form management
- **State Management**: Zustand for lightweight state management
- **UI Components**:
  - `@dnd-kit` - Drag and drop functionality
  - `@szhsin/react-accordion` - Accordion components
  - `scroll-lock` - Scroll management
- **Authentication**: JWT token-based authentication with session storage

### Database & Storage
- **Primary Database**: PostgreSQL (production-ready relational database)
- **ORM**: Entity Framework Core with Code-First migrations
- **File Storage**: Azure Blob Storage for scalable media storage
- **Database Features**:
  - Complex relationships and foreign keys
  - Entity configurations and data seeding
  - Migration-based schema management

## 🎯 Key Features

### 1. User Management & Authentication
- **Secure Registration/Login**: JWT-based authentication with ASP.NET Identity
- **User Profiles**: Comprehensive user data including body metrics, goals, and skill levels
- **Profile Management**: Update personal information, fitness goals, and preferences

### 2. Workout Plan Management
- **Create Custom Workouts**: Build personalized workout plans with exercises
- **Exercise Library**: Extensive database of exercises with muscle group targeting
- **Workout Categories**: Plans organized by skill level, goals, and body mass index
- **User Workout Collections**: Save and manage personal workout collections

### 3. Intelligent Recommendation System
- **Cosine Similarity Algorithm**: Advanced ML algorithm for personalized recommendations
- **Multi-Factor Analysis**: Considers user goals, skill level, and BMI for recommendations
- **Top-5 Suggestions**: Returns the most relevant workout plans based on similarity scores

### 4. Modern User Interface
- **Responsive Design**: Mobile-first approach with TailwindCSS
- **Interactive Components**: Drag-and-drop workout builders, animated transitions
- **Dark Theme**: Modern dark color scheme with gradient accents
- **Component Library**: Reusable UI components with consistent design

## 🧠 Machine Learning Algorithm: Cosine Similarity

### Algorithm Overview
The application implements a **cosine similarity algorithm** to provide intelligent workout recommendations. This algorithm measures the similarity between user preferences and available workout plans in a multi-dimensional vector space.

### How It Works

1. **Vector Creation**: Each user and workout plan is represented as a vector in feature space
   - **Features**: Goal type, skill level, BMI category
   - **Vocabulary**: Dynamic vocabulary built from all possible feature values

2. **User Vector**: `[goal_feature, skill_feature, bmi_feature]`
   ```csharp
   private static decimal[] BuildVector(ICollection<string> vocabulary, 
       string goal, string skill, ICollection<string> bodyMassIndex)
   {
       var vector = new decimal[vocabulary.Count];
       // Binary encoding: 1 if feature matches, 0 otherwise
       // Implementation uses vocabulary indexing for feature encoding
   }
   ```

3. **Similarity Calculation**: 
   ```csharp
   private static decimal CalculateCosineSimilarity(decimal[] userVector, decimal[] workoutVector)
   {
       var dotProduct = DotProduct(userVector, workoutVector);
       var userMagnitude = Magnitude(userVector);
       var workoutMagnitude = Magnitude(workoutVector);
       
       return dotProduct / (userMagnitude * workoutMagnitude);
   }
   ```

4. **Mathematical Formula**:
   ```
   similarity = (A · B) / (||A|| × ||B||)
   ```
   Where:
   - `A · B` = dot product of user and workout vectors
   - `||A||` = magnitude of user vector
   - `||B||` = magnitude of workout vector

5. **Ranking**: Workouts are ranked by similarity scores (0-1 range) with top 5 returned

### Benefits of Cosine Similarity
- **Scale Invariant**: Focuses on orientation rather than magnitude
- **Efficient**: Fast computation for real-time recommendations
- **Interpretable**: Similarity scores provide clear ranking rationale
- **Extensible**: Easy to add new features (age, experience, preferences)

## 🏗️ Architecture & Project Structure

### Clean Architecture Implementation
```
FitnessPlanner/
├── FitnessPlanner.Server/              # Web API Layer
│   ├── Controllers/                    # API Controllers
│   ├── Middlewares/                   # Custom middleware
│   └── Extensions/                    # Service configuration
├── FitnessPlanner.Services/           # Business Logic Layer
│   ├── Authentication/               # Auth services
│   ├── CosineSimilarityCalculation/ # ML algorithm
│   ├── Exercise/                    # Exercise management
│   ├── WorkoutPlan/                # Workout services
│   └── BodyMassIndexCalculation/   # BMI calculations
├── FitnessPlanner.Services.Models/   # DTOs and View Models
├── FitnessPlanner.Data/             # Data Access Layer
│   ├── Repositories/               # Repository implementations
│   ├── Configuration/             # Entity configurations
│   └── Migrations/               # EF migrations
├── FitnessPlanner.Data.Models/      # Domain Models
└── fitnessplanner.client/          # React Frontend
    ├── src/
    │   ├── components/            # React components
    │   ├── services/             # API services
    │   └── assets/              # Static assets
    └── public/                  # Public files
```

### API Architecture
- **RESTful Design**: Standard HTTP methods and status codes
- **Controller-Service Pattern**: Controllers handle HTTP concerns, services contain business logic
- **Result Pattern**: Consistent error handling with `Ardalis.Result`
- **Swagger Documentation**: Auto-generated API documentation
- **Global Exception Handling**: Centralized error management

### Data Layer
- **Entity Framework Core**: Code-first approach with migrations
- **Repository Pattern**: Abstracted data access with interfaces
- **Entity Configurations**: Fluent API for complex relationships
- **Database Seeding**: Initial data population for goals, skill levels, BMI categories

## 📊 Database Schema

### Core Entities
- **Users**: Extended ASP.NET Identity with fitness metrics
- **WorkoutPlans**: Complete workout definitions with metadata
- **Exercises**: Exercise library with muscle group targeting
- **Goals**: Fitness objectives (weight loss, muscle gain, etc.)
- **SkillLevels**: User experience levels (beginner, intermediate, advanced)
- **BodyMassIndexMeasure**: BMI categories for personalization

### Key Relationships
- **User ↔ WorkoutPlan**: Many-to-many (user collections)
- **WorkoutPlan ↔ Exercise**: Many-to-many (exercise composition)
- **Exercise ↔ MuscleGroup**: Many-to-many (targeted muscles)
- **User → Goal**: One-to-many (user preferences)

## 🚀 Getting Started

### Prerequisites
- **.NET 8 SDK**: [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Node.js 18+**: [Download here](https://nodejs.org/)
- **PostgreSQL**: [Download here](https://www.postgresql.org/download/)
- **Azure Storage Account**: For file storage (optional for development)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/turfinme1/FitnessPlanner.git
   cd FitnessPlanner
   ```

2. **Backend Setup**
   ```bash
   # Restore NuGet packages
   dotnet restore
   
   # Update database connection string in appsettings.json
   # Configure JWT settings and Azure storage (if using)
   
   # Run database migrations
   dotnet ef database update --project FitnessPlanner.Data
   
   # Build the solution
   dotnet build
   ```

3. **Frontend Setup**
   ```bash
   cd fitnessplanner.client
   
   # Install dependencies
   npm install
   
   # Start development server
   npm run dev
   ```

4. **Run the Application**
   ```bash
   # Start backend (from root directory)
   dotnet run --project FitnessPlanner.Server
   
   # Frontend will be available at https://localhost:5173
   # Backend API at https://localhost:7124
   ```

### Configuration

1. **Database Connection**
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=FitnessPlanner;User Id=your_user;Password=your_password;"
     }
   }
   ```

2. **JWT Configuration**
   ```json
   {
     "JwtSettings": {
       "Secret": "your-super-secret-key-here",
       "ExpiryInMinutes": 60
     }
   }
   ```

3. **Azure Storage (Optional)**
   ```json
   {
     "AzureStorage": {
       "ConnectionString": "your-azure-storage-connection-string",
       "ContainerName": "fitness-images"
     }
   }
   ```

## 🔗 API Endpoints

### Authentication
- `POST /api/authentication/register` - User registration
- `POST /api/authentication/login` - User login

### Users
- `GET /api/user/form-data` - Get user profile data
- `PUT /api/user/update-data` - Update user profile
- `GET /api/user/workout-plan` - Get user's workout plans
- `POST /api/user/workout-plan/{id}` - Add workout to user profile
- `GET /api/user/recommendation` - Get personalized recommendations

### Workout Plans
- `GET /api/workout-plan` - Get all workout plans
- `GET /api/workout-plan/{id}` - Get specific workout plan
- `POST /api/workout-plan` - Create new workout plan

### Exercises
- `GET /api/exercise` - Get all exercises
- `GET /api/exercise/{id}` - Get specific exercise
- `POST /api/exercise` - Create new exercise (Admin only)

## 🎨 UI/UX Features

### Design System
- **Color Palette**: Modern dark theme with gradient accents
- **Typography**: Custom font hierarchy with Sora and Grotesk fonts
- **Spacing**: Consistent spacing scale using TailwindCSS
- **Components**: Reusable button, card, and form components

### User Experience
- **Responsive Design**: Mobile-first approach with breakpoint optimization
- **Loading States**: Smooth loading indicators and skeleton screens
- **Form Validation**: Real-time validation with React Hook Form
- **Navigation**: Intuitive routing with React Router DOM
- **Animations**: Subtle animations with Framer Motion

### Accessibility
- **Semantic HTML**: Proper HTML semantics and ARIA labels
- **Keyboard Navigation**: Full keyboard accessibility
- **Color Contrast**: WCAG compliant color combinations
- **Screen Reader**: Screen reader friendly components

## 🔐 Security Features

### Backend Security
- **JWT Authentication**: Secure token-based authentication
- **Password Hashing**: ASP.NET Identity with secure password hashing
- **CORS Configuration**: Properly configured cross-origin requests
- **Input Validation**: Model validation and sanitization
- **Authorization**: Role-based access control

### Frontend Security
- **Token Management**: Secure token storage and automatic refresh
- **Input Sanitization**: XSS prevention measures
- **HTTPS Enforcement**: SSL/TLS encryption
- **Session Management**: Secure session handling

## 🧪 Testing

### Backend Testing
- **Unit Tests**: Service layer testing with xUnit (can be added)
- **Integration Tests**: API endpoint testing (can be added)
- **Repository Tests**: Data access layer testing (can be added)

### Frontend Testing
- **Component Tests**: React component testing with Jest/RTL (can be added)
- **E2E Tests**: End-to-end testing with Playwright (can be added)

## 📈 Performance Optimizations

### Backend Performance
- **Entity Framework Optimization**: Efficient queries with proper loading strategies
- **Caching**: Response caching for static data
- **Async/Await**: Non-blocking operations throughout
- **Connection Pooling**: PostgreSQL connection optimization

### Frontend Performance
- **Vite Optimization**: Fast build times and optimized bundles
- **Code Splitting**: Dynamic imports for large components
- **Image Optimization**: Efficient image loading and caching
- **State Management**: Lightweight state management with Zustand

## 🚀 Deployment

### Backend Deployment
- **Azure App Service**: Recommended hosting platform
- **Docker**: Containerization support available
- **Database**: Azure PostgreSQL or managed PostgreSQL service
- **File Storage**: Azure Blob Storage for production

### Frontend Deployment
- **Vercel/Netlify**: Static hosting platforms
- **Azure Static Web Apps**: Integrated with Azure backend
- **CDN**: Content delivery network for global performance

## 🔮 Future Enhancements

### Planned Features
- **Progress Tracking**: Workout completion and progress analytics
- **Social Features**: User communities and workout sharing
- **Mobile App**: React Native mobile application
- **Advanced ML**: Deep learning models for better recommendations
- **Nutrition Planning**: Meal planning and nutrition tracking
- **Wearable Integration**: Fitness tracker data integration

### Technical Improvements
- **Microservices**: Service decomposition for scalability
- **GraphQL**: Alternative API layer for flexible queries
- **Real-time Features**: SignalR for live updates
- **Advanced Caching**: Redis for distributed caching
- **Monitoring**: Application insights and logging

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## 👨‍💻 Author

- **GitHub**: [turfinme1](https://github.com/turfinme1)

## 🙏 Acknowledgments

- **Microsoft**: For the excellent .NET ecosystem
- **React Team**: For the powerful React framework
- **TailwindCSS**: For the utility-first CSS framework
- **PostgreSQL**: For the robust database system
- **Open Source Community**: For all the amazing libraries and tools

---

*Built with ❤️ using modern web technologies and best practices.*