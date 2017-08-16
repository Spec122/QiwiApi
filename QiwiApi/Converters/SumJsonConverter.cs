﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QiwiApi.Converters {
	public class SumJsonConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			JObject jsonObject = JObject.Load(reader);
			return jsonObject.GetValue("amount").ToObject<decimal>();
		}

		public override bool CanConvert(Type objectType) {
			return typeof(decimal).IsAssignableFrom(objectType);
		}
	}
}
