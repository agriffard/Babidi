# PRD --- Blazor WASM Dashboard Application

## 1. Overview

### 1.1 Purpose

Build a modern, responsive Blazor WebAssembly dashboard application
using:

-   BlazorBlueprintUI\
-   https://github.com/blazorblueprintui/ui\
-   BlazorBlueprint.Components (v2.5.0)

The application will provide a professional dashboard layout with
sidebar navigation, charts, data tables, forms, profile management,
flyout panels, and authentication.

------------------------------------------------------------------------

## 2. Goals & Objectives

### 2.1 Goals

-   Provide a clean, enterprise-ready dashboard UI.
-   Ensure full responsiveness (desktop, tablet, mobile).
-   Support Light/Dark theme switching.
-   Deliver reusable layout and components.
-   Provide scalable structure for future modules.

### 2.2 Non-Goals

-   Complex backend business logic (initial scope).
-   Advanced role-based access control (basic auth only for MVP).
-   Multi-tenant architecture (future enhancement).

------------------------------------------------------------------------

## 3. Technology Stack

-   Frontend: Blazor WebAssembly (.NET 8+)
-   UI Library: BlazorBlueprint Components (v2.5.0)
-   Styling: Tailwind (via Blueprint)
-   Charts: Chart.js wrapper for Blazor
-   Auth: JWT-based authentication (mockable)
-   State Management: Scoped services

------------------------------------------------------------------------

## 4. Application Layout

Reference layout: https://blazorblueprintui.com/blueprints/sidebar-02

### 4.1 Main Layout Structure

-   Left Sidebar (collapsible)
-   Top Responsive Navbar
-   Breadcrumbs
-   Main Content Area

### 4.2 Header (Top Navbar)

Elements: - Breadcrumb navigation - Theme toggle (Light/Dark) - User
avatar dropdown - Optional notifications icon

Behavior: - Fully responsive - Collapses into hamburger on small
screens - Theme toggle persists user preference (local storage)

### 4.3 Sidebar

Position: Left\
Behavior: Collapsible + responsive overlay on mobile

Content: - Logo (top-left) - Application Title - Navigation items with
submenus

Example Navigation Structure:

-   Dashboard
-   Management
    -   Items
    -   Categories
-   Users
-   Profile
-   Settings

Features: - Active route highlighting - Expand/collapse submenus -
Collapsible sidebar mode (icon-only)

------------------------------------------------------------------------

## 5. Features & Pages

### 5.1 Dashboard Page

Route: `/dashboard`

Components: - Stats Cards - Line/Bar charts - Activity summary section -
Quick action buttons

Stats Cards Example: - Total Users - Revenue - Active Sessions - Growth
%

------------------------------------------------------------------------

### 5.2 Data Table Page

Route: `/items`

Features: - Paginated table - Sorting - Search/filter - Row click
navigation - Responsive design

Columns Example: - ID - Name - Status - Created Date - Actions

Pagination: - Page size selector - Page number navigation - Server-side
ready (MVP can be client-side)

Row Interaction: - Clicking a row → navigates to `/items/edit/{id}`

------------------------------------------------------------------------

### 5.3 Create / Edit Form Page

Routes: - `/items/create` - `/items/edit/{id}`

Features: - Reusable form component - Validation (DataAnnotations) -
Loading state - Save / Cancel buttons

Input Types: - Text input - Textarea - Select dropdown - Multi-select -
Switch (boolean) - Date picker - Number input - Tabs sectioning form
groups - Action buttons

UX Behavior: - Dirty state detection - Validation summary - Confirmation
before leaving unsaved changes

------------------------------------------------------------------------

### 5.4 Profile Page

Route: `/profile`

Sections: - Personal info - Change password - Preferences (theme,
notifications) - Avatar upload

------------------------------------------------------------------------

### 5.5 Flyout Panel

Use Cases: - Quick view item details - Inline edit preview -
Notifications panel

Behavior: - Slide-in from right - Overlay background - Close on ESC or
outside click - Reusable component

------------------------------------------------------------------------

### 5.6 Login Page

Route: `/login`

Layout: - Centered card - Logo at top - Title - Email input - Password
input - Remember me checkbox - Login button - Optional "Forgot password"

Behavior: - Validation - Loading indicator - Redirect to `/dashboard` on
success - Store JWT token

------------------------------------------------------------------------

## 6. Theme Management

Light / Dark Toggle: - Toggle button in navbar - Persist preference in
LocalStorage - Apply on app initialization

------------------------------------------------------------------------

## 7. Routing Structure

/login\
/dashboard\
/items\
/items/create\
/items/edit/{id}\
/profile\
/settings

Protected routes require authentication.

------------------------------------------------------------------------

## 8. State Management

Services: - AuthService - ThemeService - ItemService - UserService

Scoped lifetime for WASM.

------------------------------------------------------------------------

## 9. Responsive Requirements

Desktop: - Sidebar: Fixed - Navbar: Full - Table: Full

Tablet: - Sidebar: Collapsible - Navbar: Responsive - Table: Scrollable

Mobile: - Sidebar: Overlay - Navbar: Hamburger - Table: Stacked

------------------------------------------------------------------------

## 10. Performance Requirements

-   First load under 3 seconds (optimized build)
-   Lazy load large modules if necessary
-   Minimize JS interop

------------------------------------------------------------------------

## 11. Accessibility

-   Keyboard navigation
-   Proper ARIA labels
-   Sufficient color contrast
-   Focus indicators

------------------------------------------------------------------------

## 12. Folder Structure (Proposed)

/Layouts\
MainLayout.razor\
LoginLayout.razor

/Components\
Sidebar\
Navbar\
Breadcrumb\
ThemeToggle\
StatsCard\
FlyoutPanel

/Pages\
Dashboard\
Items\
Profile\
Login

/Services\
AuthService\
ThemeService\
ItemService

/Models

------------------------------------------------------------------------

## 13. Future Enhancements

-   Role-based access control
-   Real-time notifications (SignalR)
-   Multi-language support
-   API integration
-   Export to CSV/Excel
-   Advanced filtering
-   Drag-and-drop dashboard widgets

------------------------------------------------------------------------

## 14. Success Criteria

-   Fully functional responsive layout
-   Smooth theme switching
-   Working pagination and forms
-   Clean and maintainable architecture
-   Production-ready UI foundation
