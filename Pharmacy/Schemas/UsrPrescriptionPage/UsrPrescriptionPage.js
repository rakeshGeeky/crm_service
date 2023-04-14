define("UsrPrescriptionPage", [], function() {
	return {
		entitySchemaName: "UsrPrescription",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "LOOKUP3031c1a4-5465-467a-9e8b-78c79ab083ee",
				"values": {
					"layout": {
						"colSpan": 7,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrMedicineName",
					"enabled": true,
					"contentType": 5
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "INTEGER962f0ca8-aef9-4924-851e-c9060b64ead6",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 7,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrQuantity",
					"enabled": true
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_DIFF*/
	};
});
