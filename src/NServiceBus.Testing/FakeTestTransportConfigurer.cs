namespace NServiceBus.Testing
{
    using Features;
    using Transports;

    class FakeTestTransportConfigurer : ConfigureTransport
    {
        protected override void Configure(FeatureConfigurationContext context, string connectionString)
        {
        }

        protected override string ExampleConnectionStringForErrorMessage
        {
            get { return "FooBar"; }
        }
    }
}